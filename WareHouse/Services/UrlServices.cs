using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Services.IServices;

namespace WareHouse.Services
{
    public class UrlServices : IUrlServices
    {
        public  List<string> GetRouteUrlWithAuthorizeAttribute()
        {
            // Get all the components whose base class is ComponentBase
            var components = Assembly.GetExecutingAssembly()
                                   .ExportedTypes
                                   .Where(t =>
                                  t.IsSubclassOf(typeof(ComponentBase)));
            var result =   components
                        .Select(component => GetRouteFromComponent(component))
                        .Where(config => config is not null)
                        .ToList();
            return result;
        }
        public string GetRouteFromComponent(Type component)
        {
            var attributes = component.GetCustomAttributes(inherit: true);
            var routeAttribute = attributes.OfType<RouteAttribute>().FirstOrDefault();

            if (routeAttribute is null)
            {
                //Only map routable components
                return null;
            }
            return component.ToString();
        }
    }
}
