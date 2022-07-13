using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.InformationUser;

namespace WareHouse.Models.PersonTypes
{
    public class Personal
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "باید نام را وارد کنید")]
        public string Name { get; set; }
        [Display(Name = "نام پدر")]
        [Required(ErrorMessage = "باید نام پدر را وارد کنید")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "باید کد پستی را وارد کنید")]
        [Display(Name = "کد پستی")]
        public string CodePostal { get; set; }
        [Required(ErrorMessage = "باید تلفن همراه را وارد کنید")]
        [Display(Name = "تلفن همراه")]
        public string CellularPhone { get; set; }
        [Required(ErrorMessage = "باید تلفن ثابترا وارد کنید")]
        [Display(Name = "تلفن ثابت")]
        public string Phone { get; set; }
        [Display(Name = "آدرس سایت")]
        public string UrlWebsite { get; set; }
        [Required(ErrorMessage = " تاریخ تولد را وارد کنید")]
        [Display(Name = "تاریخ تولد")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "استان را وارد کنید")]
        [Display(Name = "استان")]

        public string State { get; set; }
        [Required(ErrorMessage = "شهر را وارد کنید")]
        [Display(Name = "شهر")]
        public string City { get; set; }
        [Required(ErrorMessage = "شهرستان را وارد کنید")]
        [Display(Name = "شهرتان")]
        public string Township { get; set; }

        [Required(ErrorMessage = "کد ملی را وارد کنید")]
        [Display(Name = "کد ملی")]
        public string CodeNational { get; set; }
        [Required(ErrorMessage = "ایمیل را وارد کنید")]
        [Display(Name = "ایمیل")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "آدرس فکس را وارد کنید")]
        [Display(Name = "آدرس فکس")]
        public string Fax { get; set; }

        [ForeignKey("AccountBank")]
        [Display(Name = "اکانت خود را انتخاب کنید")]
        public int AccountBankId { get; set; }
        [ValidateNever]
        public AccountBank AccountBank { get; set; }


    }
}
