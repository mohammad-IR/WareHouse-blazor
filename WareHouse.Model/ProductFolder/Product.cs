using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.RawMaterials;

namespace WareHouse.Models.ProductFolder
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="باید نام را وارد کنید")]
        public string Name { get; set; }

        [ValidateNever]
        public IList<RawMaterial> RawMaterials { get; set; }

        public DateTime DateOfCreate { get; set; } = DateTime.Now;

        [Required(ErrorMessage ="باید هزینه مونتاژ را وارد کنید")]
        public double AssemblyPrice { get; set; }


    }
}
