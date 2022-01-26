using System.Threading.Tasks;

namespace HiddenVilla_Server.Service.IService
{
    public interface IFileUpload
    {
        public Task<string> FileUpload(IBrowser browser);

        public bool DeleteFile(string filePath);
    }
}
