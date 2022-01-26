namespace HiddenVilla_Server.Service
{
    using IService;
    using System.Threading.Tasks;

    public class FileUpload : IFileUpload
    {
        public bool DeleteFile(string filePath)
        {
            throw new System.NotImplementedException();
        }

        Task<string> UploadFile(IBrowser browser)
        {
            throw new System.NotImplementedException();
        }
    }
}
