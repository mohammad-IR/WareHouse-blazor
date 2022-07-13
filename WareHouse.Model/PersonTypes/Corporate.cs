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
    public class Corporate
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "باید نام شرکت را وارد کنید")]
        [Display(Name = "نام شرکت")]
        public string Name { get; set; }


        [Required(ErrorMessage = "باید نوع شرکت را وارد کنید")]
        [Display(Name = "نوع شرکت")]
        public string Type { get; set; }

        [Display(Name = "کشور")]
        [Required(ErrorMessage = "باید کشور را وارد کنید")]
        public string Country { get; set; }

        [Display(Name = "استان")]
        [Required(ErrorMessage = "باید استان را وارد کنید")]
        public string State { get; set; }

        [Display(Name = "شهر")]
        [Required(ErrorMessage = "باید شهر را وارد کنید")]
        public string City { get; set; }

        [Display(Name = "شماره دفتر مرکزیی")]
        [Required(ErrorMessage = "باید شماره دفتر مرکزیی را وارد کنید")]
        public string HeadquartersNumber { get; set; }

        [Display(Name = "تاریخ تاسیس")]
        [Required(ErrorMessage = "باید تاریخ تاسیس را وارد کنید")]
        public DateTime DateOfEstablish { get; set; }

        [Required(ErrorMessage = "در بکند تاریخ را ایجاد وارد نشده است به پشتیبانی اطلاع دهید")]
        public DateTime DateOfCreateInDatabase { get; set; }

        [Display(Name = "شماره ثبت")]
        [Required(ErrorMessage = "باید شماره ثبت را وارد کنید")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "باید ایمیل شکرت را وارد کنید")]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage = "باید آدرس را وارد کنید")]
        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Display(Name = "آدرس سایت")]
        public string UrlWebsite { get; set; }
        [Display(Name = "شماره اقتصادی")]
        public string EcinimicCode { get; set; }


        [Required(ErrorMessage = "باید کد پستی را وارد کنید")]
        [Display(Name = "کد پستی")]
        public string CodePostal { get; set; }

        [Required(ErrorMessage ="باید حساب داشته باشید")]
        [ForeignKey("AccountBank")]
        public int AccountBankId { get; set; }
        [ValidateNever]
        public AccountBank AccountBank { get; set; }


        [Display(Name = "توضیحات")]
        public string Description { get; set; }
    }
}
