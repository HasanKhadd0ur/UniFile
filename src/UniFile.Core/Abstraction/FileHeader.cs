using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniFile.Core.Abstraction
{
    public class FileHeader
    {
        /// <summary>
        /// Gets or sets the unique key for the file.
        /// </summary>
        public string FileKey { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the content type of the file (e.g., "application/pdf").
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the size of the file in bytes.
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// Gets or sets additional metadata related to the file.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();
    }

}
