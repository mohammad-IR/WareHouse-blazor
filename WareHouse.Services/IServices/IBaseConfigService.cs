using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.CurrenciesPrice;
using WareHouse.Utilities;

namespace WareHouse.Services.IServices
{
    public interface IBaseConfigService
    {
        public Result ChangeCurrencyDefult(CurrencyPrice currency);
    }
}
