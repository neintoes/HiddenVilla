using System.Threading.Tasks;

namespace HiddenVilla_Server.Service.IService
{
    public interface IFileUpload
    {
        public Task<string> UploadFile(IBrowser browser);

        public bool DeleteFile(string filePath);
    }
}
