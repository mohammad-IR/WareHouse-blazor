using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WareHouse.Models.InformationUser;
using WareHouse.Models.CurrenciesPrice;
using WareHouse.Models.RawMaterials;

namespace WareHouse.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<AccountBank> accountBanks { get; set; }
        public DbSet<TitleJobs> TitleJobs { get; set; }


        // RawMaterials
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<AttributesProperty> AttributesProperties { get; set; }

        public DbSet<CurrencyPrice> CurrenciesPrice { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // RawMaterials
            builder.Entity<RawMaterial>()
                .HasIndex(u => u.PartNumber)
                .IsUnique();
            builder.Entity<Property>()
                .HasIndex(u => u.Name)
                .IsUnique();
            builder.Entity<CurrencyPrice>()
                .HasIndex(u => u.Type)
                .IsUnique();

        }
    }
}
