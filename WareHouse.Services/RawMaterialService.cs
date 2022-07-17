using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.DataAccess.Data;
using WareHouse.Models.ViewModels.RawMaterialVM;
using WareHouse.Services.IServices;
using WareHouse.Utilities;

namespace WareHouse.Services
{
    public class RawMaterialService : IRawMaterialService
    {
        public ApplicationDbContext _db { get; set; }
        public RawMaterialService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<RawMaterialListVM> GetRawMaterials()
        {
            return _db.RawMaterials
                    .Include(item => item.CurrencyPriceType)
                    .Include(item => item.Supplier)
                    .Select(item => new RawMaterialListVM()
                    {
                        RawMaterial = item,
                        NameSupplier = (item.Supplier.Type == SupplierUtilities.Personal ? _db.Personals.FirstOrDefault(i => i.Id == item.Supplier.TypeId).Name : _db.Corporates.FirstOrDefault(i => i.Id == item.Supplier.TypeId).Name),
                        PhoneNumberSupplier = (item.Supplier.Type == SupplierUtilities.Personal ? _db.Personals.FirstOrDefault(i => i.Id == item.Supplier.TypeId).CellularPhone : _db.Corporates.FirstOrDefault(i => i.Id == item.Supplier.TypeId).HeadquartersNumber)
                    }).ToList();
        }
        public RawMaterialListVM GetRawMatrial(int id)
        {
            return _db.RawMaterials.
                        Include(item => item.Supplier).
                        Include(item => item.CurrencyPriceType)
                        .Select(item =>
                                new RawMaterialListVM()
                                {
                                    RawMaterial = item,
                                    NameSupplier = (item.Supplier.Type == SupplierUtilities.Personal ? _db.Personals.FirstOrDefault(i => i.Id == item.Supplier.TypeId).Name : _db.Corporates.FirstOrDefault(i => i.Id == item.Supplier.TypeId).Name),
                                    PhoneNumberSupplier = (item.Supplier.Type == SupplierUtilities.Personal ? _db.Personals.FirstOrDefault(i => i.Id == item.Supplier.TypeId).CellularPhone : _db.Corporates.FirstOrDefault(i => i.Id == item.Supplier.TypeId).HeadquartersNumber)
                                }
                                 ).Single();
        }
        public async Task<Result> DeleteRawMaterial(int id)
        {
            var rawMaterial = _db.RawMaterials.FirstOrDefault(item => item.Id == id);
            if (rawMaterial == null)
            {
                return Result.Failure;
            }
            try
            {
                var rawMaterialsProp = _db.RawMaterialProperties.Where(item => item.RawMaterialId == rawMaterial.Id).ToList();
                _db.RawMaterialProperties.RemoveRange(rawMaterialsProp);
                await _db.SaveChangesAsync();
                try
                {
                    _db.RawMaterials.Remove(rawMaterial);
                    await _db.SaveChangesAsync();
                }
                catch
                {
                    foreach (var item in rawMaterialsProp)
                    {
                        await _db.RawMaterialProperties.AddAsync(item);
                    }
                    await _db.SaveChangesAsync();
                    return Result.Failure;
                }
            }
            catch
            {
                return Result.Failure;
            }
            return Result.Success;
        }
    }
}
