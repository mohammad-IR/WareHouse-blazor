using Microsoft.AspNetCore.Mvc.Rendering;
using WareHouse.Models.RawMaterials;

namespace WareHouse.Models.ViewModels.RawMaterialsViewModel
{
    public class RawMaterialViewModel
    {   
        public RawMaterial RawMaterial { get; set; } = new RawMaterial();

        public List<SelectListItem> Suppliers { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> Currenies { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> Properties { get; set; } = new List<SelectListItem>();
    }
}
