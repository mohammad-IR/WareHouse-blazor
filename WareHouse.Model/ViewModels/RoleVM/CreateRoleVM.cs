using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Models.ViewModels.RoleVM
{
    public class CreateRoleVM
    {
        [Required(ErrorMessage ="باید نام role را وارد کنید")]
        public string NameRole { get; set; }

        [ValidateNever]
        public Dictionary<string, bool> Claims { get; set; }
    }
}
