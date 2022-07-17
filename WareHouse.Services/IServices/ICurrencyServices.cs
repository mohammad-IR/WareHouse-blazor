using WareHouse.Models.CurrenciesPrice;
using WareHouse.Utilities;

namespace WareHouse.Services.IServices
{
    public interface ICurrencyServices
    {
        public Result CalCulateByBaseCurrency(CurrencyPrice past, CurrencyPrice now);
    }
}
