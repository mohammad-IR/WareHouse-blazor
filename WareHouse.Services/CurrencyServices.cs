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
    public class CurrencyServices : ICurrencyServices
    {
        public ApplicationDbContext _db { get; set; }
        public CurrencyServices(ApplicationDbContext db)
        {
            _db = db;
        }
        public Result CalCulateByBaseCurrency(CurrencyPrice past, CurrencyPrice now)
        {
            try
            {
                var currencies = _db.CurrenciesPrice.Where(item=> item.Id != past.Id && item.Id != now.Id ).ToList();
                foreach(var currency in currencies)
                {
                    currency.BaseCurrencyValue *= past.BaseCurrencyValue;
                    _db.Update(currency);
                }
                _db.SaveChanges();
                return Result.Success;
            }
            catch
            {
                return Result.Failure;
            }
        }

    }
}
