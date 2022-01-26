namespace HiddenVilla_Server.Service
{
    using IService;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Hosting;
    using System;
    using System.IO;
    using System.Threading.Tasks;

    public class FileUpload: IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUpload(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public bool DeleteFile(string fileName)
        {
            try
            {
                var path = $"{_webHostEnvironment.WebRootPath}\\RoomImages\\{fileName}";
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        /// <summary>
        /// UploadFile returns a string that is the filepath of the final uploaded file upon completion of the method. 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> UploadFile(IBrowserFile file)
        {
            try
            {
                //notes for here.. 
                //the Guid is like a hash identifier to give the file a name.
                //THe folder directory is gained from IWebHostEnvironment.WebRoot path which tthe documentation states:
                //'Gets or sets the absolute path to the directory that contains the web-servable application content files.'


                FileInfo fileInfo = new FileInfo(file.Name);
                var fileName = Guid.NewGuid().ToString() + fileInfo.Extension;
                var folderDirectory = $"{_webHostEnvironment.WebRootPath}\\RoomImages";
                var path = Path.Combine(_webHostEnvironment.WebRootPath, "RoomImages", fileName);
                //This path.combine method takes these parameters in to generate a file path.

                //The memoryStream is:
                //"The MemoryStream class can be used as the backing source for data you want to keep in memory. This makes it a great temporary storage for data
                //coming from a file or a network resource, to prevent lockups etc. while you work with the data." - https://csharp.net-tutorials.com/data-streams/memorystream/
                var memoryStream = new MemoryStream();
                await file.OpenReadStream().CopyToAsync(memoryStream);
                //OpenReadStream will "Open the request stream for readinf the uploaded file.

                await using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    Console.WriteLine("got here.");
                    memoryStream.WriteTo(fs);
                }

                var fullPath = $"RoomImages/{fileName}";
                return fullPath;
            }  
            catch(Exception ex)
            {
                Console.WriteLine("This is an exception from FileUpload: " + ex.ToString());
                throw new Exception(ex.ToString());
            }


        }
    }
}
