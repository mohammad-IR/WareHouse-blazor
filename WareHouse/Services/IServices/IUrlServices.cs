using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Services.IServices
{
    public  interface IUrlServices
    {
        public List<string> GetRouteUrlWithAuthorizeAttribute();
        public string GetRouteFromComponent(Type component);
    }
}
