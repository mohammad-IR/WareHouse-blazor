using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.DataAccess.Data;
using WareHouse.Models.ViewModels.SupplierVM;
using WareHouse.Services.IServices;
using WareHouse.Utilities;

namespace WareHouse.Services
{
    public class SupplierService : ISupplierService
    {
        public ApplicationDbContext _db { get; set; }
        public SupplierService(ApplicationDbContext db)
        {
            _db = db;
        }
        public ListOfSuppliersVM GetAllSuppliers()
        {
            ListOfSuppliersVM listOfSuppliersVM = new ListOfSuppliersVM();
            listOfSuppliersVM.Personals = _db.Suppliers.
                Where(item => item.Type == SupplierUtilities.Personal).
                Select(item => _db.Personals.FirstOrDefault(i => i.Id == item.TypeId))
                .ToList();
            listOfSuppliersVM.Corporates = _db.Suppliers.
                Where(item => item.Type == SupplierUtilities.Corprate).
                Select(item => _db.Corporates.FirstOrDefault(i => i.Id == item.TypeId))
                .ToList();
            return listOfSuppliersVM;
        }
    }
}
