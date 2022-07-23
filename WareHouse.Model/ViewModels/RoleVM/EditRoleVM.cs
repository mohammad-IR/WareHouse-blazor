using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Models.ViewModels.RoleVM
{
    public class EditRoleVM
    {
        public IdentityRole Role { get; set; }
        [Required(ErrorMessage = "باید نام role را وارد کنید")]
        public string NameRole { get; set; }

        [ValidateNever]
        public Dictionary<string, bool> NewClaims { get; set; } = new Dictionary<string, bool>();
        public IList<Claim> Claims { get; set; } 
    }
}
