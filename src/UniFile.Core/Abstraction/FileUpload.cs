using Microsoft.AspNetCore.Http;

namespace UniFile.Core.Abstraction
{
    public class FileUpload
    {
        /// <summary>
        /// Gets or sets the file header containing metadata.
        /// </summary>
        public FileHeader Header { get; set; }

        /// <summary>
        /// Gets or sets the uploaded file.
        /// </summary>
        public IFormFile File { get; set; }

        public FileUpload(FileHeader header, IFormFile file)
        {
            Header = header;
            File = file;
        }
    }

}
