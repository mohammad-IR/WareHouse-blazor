using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Models.RawMaterials
{
    public class RawMaterialProperty
    {
        [Key]
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int RawMaterialId { get; set; }
    }
}
