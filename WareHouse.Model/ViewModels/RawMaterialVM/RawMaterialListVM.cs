using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.RawMaterials;

namespace WareHouse.Models.ViewModels.RawMaterialVM
{
    public class RawMaterialListVM 
    {
        public RawMaterial RawMaterial { get; set; }
        public string NameSupplier { get; set; }
        public string PhoneNumberSupplier { get; set; }
    }
}
