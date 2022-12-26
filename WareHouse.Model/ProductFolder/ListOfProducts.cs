using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.WareHouseModel;

namespace WareHouse.Models.ProductFolder
{
    public class ListOfProducts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId ")]
        public Product Product { get; set; }
        public int Numbers { get; set; }

        [Required]
        public int PlaceOfSavedId { get; set; }
        [Required]
        public WareHouseModel.WareHouse WareHouse { get; set; }
    }
}
