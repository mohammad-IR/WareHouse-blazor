using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.RawMaterials;

namespace WareHouse.Models.ProductFolder
{
    public class ProductRawMaterials
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MaterialId { get; set; }
        [ForeignKey("MaterialId ")]
        public RawMaterial RawMaterial { get; set; }
        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId ")]
        public Product Product { get; set; }
    }
}
