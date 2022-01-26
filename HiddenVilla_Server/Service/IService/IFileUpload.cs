using Microsoft.AspNetCore.Components.Forms;
using System.Threading.Tasks;

namespace HiddenVilla_Server.Service.IService
{
    public interface IFileUpload
    {
        public bool DeleteFile(string fileName);

        public Task<string> UploadFile(IBrowserFile browser);
    }
}
