using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WareHouse.DataAccess.Data;
using WareHouse.DataAccess.CodeFirst;
using WareHouse.Data;
using WareHouse.Models.InformationUser;
using WareHouse.Services.IServices;
using WareHouse.Services;
var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(x => 
                            x.User.RequireUniqueEmail = false)
    .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders().AddDefaultUI()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddScoped<IDbInitialzer, DbInitializer>();
builder.Services.AddScoped<IPropertyServices, PropertyServices>();
builder.Services.AddScoped<IBaseConfigService, BaseConfigService>();
builder.Services.AddScoped<ICurrencyServices, CurrencyServices>();
builder.Services.AddScoped<IRawMaterialService, RawMaterialService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<IUrlServices, UrlServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

SeedDatabase();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitialzer>();
        dbInitializer.Initiilzer();
    }
}