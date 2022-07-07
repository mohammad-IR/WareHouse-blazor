using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.RawMaterials;

namespace WareHouse.Models.ViewModels.PropertyVM
{
    public class GetPropertyVM
    {
        public Property Property { get; set; }
        public List<AttributesProperty> AttributesProperties { get; set; } = new List<AttributesProperty>();
    }
}
