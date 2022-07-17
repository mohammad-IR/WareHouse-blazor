using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.CurrenciesPrice;
using WareHouse.Models.RawMaterials;
using WareHouse.Models.ViewModels.SupplierVM;

namespace WareHouse.Models.ViewModels.RawMaterialVM
{
    public class CreateRawMaterialVM
    {
        public RawMaterial RawMaterial { get; set; } = new RawMaterial();
        public ListOfSuppliersVM Suppliers { get; set; }
        public List<CurrencyPrice> Currecnies { get; set; }
        public List<Property> Properties { get; set; }

    }
}
