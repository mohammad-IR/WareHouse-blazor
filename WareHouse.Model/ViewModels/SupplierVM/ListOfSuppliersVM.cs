using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.PersonTypes;

namespace WareHouse.Models.ViewModels.SupplierVM
{
    public class ListOfSuppliersVM
    {
        public List<Personal> Personals { get; set; }
        public List<Corporate> Corporates { get; set; }
    }
}
