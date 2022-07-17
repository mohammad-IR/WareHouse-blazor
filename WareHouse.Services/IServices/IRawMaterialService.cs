using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models.ViewModels.RawMaterialVM;
using WareHouse.Utilities;

namespace WareHouse.Services.IServices
{
    public interface IRawMaterialService
    {
        public List<RawMaterialListVM> GetRawMaterials();
        public RawMaterialListVM GetRawMatrial(int id);
        public Task<Result> DeleteRawMaterial(int id);
    }
}
