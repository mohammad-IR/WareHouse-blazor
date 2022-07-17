using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.ViewModels.SupplierVM;

namespace WareHouse.Services.IServices
{
    public interface ISupplierService
    {
        public ListOfSuppliersVM GetAllSuppliers();
    }
}
