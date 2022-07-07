using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.ViewModels.PropertyVM;

namespace WareHouse.Services.IServices
{
    public interface IPropertyServices
    {
        public GetPropertyVM GetProperty(int id);
    }
}
