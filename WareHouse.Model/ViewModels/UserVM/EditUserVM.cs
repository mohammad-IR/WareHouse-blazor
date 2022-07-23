using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Models.ViewModels.UserVM
{
    public class EditUserVM
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email{ get; set; }

        [NotMapped]
        public string? Password { get; set; }
        [NotMapped]
        [Compare("Password", ErrorMessage = "باید پسورد یکی باشد ")]
        public string? PasswordConfrim { get; set; }
        public string UserName { get; set; }

        public string? PhoneNumber { get; set; }

        public Dictionary<string, string> Roles { get; set; } = new Dictionary<string, string>();
        public string RoleUser { get; set; }
    }

}
