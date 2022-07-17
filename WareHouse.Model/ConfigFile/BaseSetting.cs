using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.CurrenciesPrice;

namespace WareHouse.Models.ConfigFile
{
    public class BaseSetting
    {
        [Key]

        public int Id { get; set; }

        [Required]
        [ForeignKey("CurrencyPriceBase")]
        public int CurrencyPriceBaseId { get; set; }
        [ValidateNever]
        public CurrencyPrice CurrencyPriceBase { get; set; }

    }
}
