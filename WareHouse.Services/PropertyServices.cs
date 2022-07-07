using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.DataAccess.Data;
using WareHouse.Models.ViewModels.PropertyVM;
using WareHouse.Services.IServices;
using WareHouse.Utilities;

namespace WareHouse.Services
{
    public class PropertyServices : IPropertyServices
    {
        private ApplicationDbContext _db { get; set; }
        public PropertyServices(ApplicationDbContext db)
        {
            _db = db;
        }
        public GetPropertyVM GetProperty(int id)
        {
            GetPropertyVM getProperty = new GetPropertyVM();
            getProperty.Property = _db.Properties.FirstOrDefault(p => p.Id == id);
            if (getProperty.Property== null)
            {
                return null;
            }
            if(getProperty.Property.Type == PropertyUtitlies.Drapdown)
            {
                getProperty.AttributesProperties = _db.AttributesProperties.Where(item => item.IdProperty == id).ToList();
            }
            return getProperty;
        }
    }
}
