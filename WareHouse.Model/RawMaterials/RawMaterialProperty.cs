using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Models.RawMaterials
{
    public class RawMaterialProperty
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        [ValidateNever]
        public Property Property { get; set; }
        [ForeignKey("RawMaterial")]
        public int RawMaterialId { get; set; }
        [ValidateNever]
        public RawMaterial RawMaterial { get; set; }
    }
}
