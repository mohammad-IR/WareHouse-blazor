using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.InformationUser;

namespace WareHouse.Models.ViewModels.UserVM
{
    public class CreateUserVM
    {
        public ApplicationUser User { get; set; } = new ApplicationUser();
        public Dictionary<string, string> Roles { get; set; }
        public string RoleUser { get; set; }

    }
}
