using Microsoft.AspNetCore.Components.Forms;
using WareHouse.Services.IServices;
using Microsoft.AspNetCore.Hosting;

namespace WareHouse.Services
{
    public class FileUpload : IFileUpload
    {
        public bool DeleteFile(string filePath)
        {
            return true;
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            await Task.Delay(1);
            return "";
        }
    }
}
