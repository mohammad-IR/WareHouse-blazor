using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.DataAccess.Data;
using WareHouse.Models.CurrenciesPrice;
using WareHouse.Services.IServices;
using WareHouse.Utilities;

namespace WareHouse.Services
{
    public class BaseConfigService : IBaseConfigService
    {
        public ApplicationDbContext _db { get; set; }
        public ICurrencyServices _ICurrencyServices { get; set; }
        public BaseConfigService(ApplicationDbContext db, ICurrencyServices iCurrencyServices)
        {
            _db = db;
            _ICurrencyServices = iCurrencyServices; 
        }
        public Result ChangeCurrencyDefult(CurrencyPrice currency)
        {
            try
            {
                //get from setting base and currencybase from database
                var settingBase = _db.BaseSettings.
                    Include(item => item.CurrencyPriceBase).
                    ToList()[0];
                var CurrencyBase = settingBase.CurrencyPriceBase;
                // swiching currenybase
                CurrencyBase.BaseCurrencyValue /= currency.BaseCurrencyValue;
                currency.BaseCurrencyValue = 1;
                //set to seeting base
                settingBase.CurrencyPriceBaseId = currency.Id;
                //save changes
                _db.CurrenciesPrice.Update(currency);
                _db.CurrenciesPrice.Update(CurrencyBase);
                _db.BaseSettings.Update(settingBase);
                _db.SaveChanges();
                var result = _ICurrencyServices.CalCulateByBaseCurrency(CurrencyBase, currency);
                if(result == Result.Failure)
                {
                    currency.BaseCurrencyValue /= CurrencyBase.BaseCurrencyValue;
                    CurrencyBase.BaseCurrencyValue = 1;
                    _db.SaveChanges();
                }
                return Result.Success;
            }
            catch
            {
                return Result.Failure;
            }
        }
    }
}
