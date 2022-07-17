using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.DataAccess.Data;
using WareHouse.Models.ConfigFile;
using WareHouse.Models.CurrenciesPrice;
using WareHouse.Models.InformationUser;

namespace WareHouse.DataAccess.CodeFirst
{
    public class DbInitializer : IDbInitialzer
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private ApplicationDbContext _db;

        public DbInitializer(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }
        public void Initiilzer()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "m.ilaghi5273@gmail.com",
                    FirstName = "mohammad sadegh",
                    LastName = "Ilaghi hoseini",
                    Email = "m.ilaghi5273@gmail.com",
                    PhoneNumber = "09162785273",
                    Address = "کرما بلوار جهاد",
                    City = "کرمان",
                    CodeNational = "29212322033",
                    dateOfBirth = DateTime.Now,

                }, "Admin123*").GetAwaiter().GetResult();
                var baseCurrency = new CurrencyPrice()
                {
                    BaseCurrencyValue = 1,
                    Type = "ريال"
                };
                _db.CurrenciesPrice.Add(baseCurrency);
                _db.SaveChanges();
                if (_db.BaseSettings.ToList().Count == 0)
                {
                    _db.BaseSettings.Add(new BaseSetting()
                    {
                        CurrencyPriceBaseId = baseCurrency.Id
                    });
                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
