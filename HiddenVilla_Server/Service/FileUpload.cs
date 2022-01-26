namespace HiddenVilla_Server.Service
{
    using IService;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Hosting;
    using System;
    using System.Threading.Tasks;

    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUpload(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public bool DeleteFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadFile(IBrowser browser)
        {
            throw new NotImplementedException();
        }
    }
}
