using System.Threading.Tasks;

namespace HiddenVilla_Server.Service.IService
{
    public interface IFileUpload
    {
        public bool DeleteFile(string filePath);

        public Task<string> UploadFile(IBrowser browser);
    }
}
