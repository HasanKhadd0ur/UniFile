using FluentResults;
using System.Threading.Tasks;
using UniFile.Core.Abstraction;

namespace UniFile.Core.Services
{
    /// <summary>
    /// Defines the contract for file management operations, supporting asynchronous CRUD operations.
    /// </summary>
    interface IFileService
    {
        /// <summary>
        /// Creates a new file with the specified name and content.
        /// </summary>
        /// <param name="fileUpload">An object containing the file's header and content.</param>
        /// <returns>A task representing the asynchronous operation, with the file's unique key upon creation.</returns>
        Task<Result<string>> CreateFileAsync(FileUpload fileUpload);

        /// <summary>
        /// Reads the content of the specified file.
        /// </summary>
        /// <param name="fileKey">The unique key of the file to read.</param>
        /// <returns>A task representing the asynchronous operation, with the file's content encapsulated in a <see cref="FileUpload"/> object.</returns>
        Task<Result<FileUpload>> ReadFileAsync(string fileKey);

        /// <summary>
        /// Updates the content of the specified file.
        /// </summary>
        /// <param name="fileUpload">An object containing the updated file's header and content.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task<Result> UpdateFileAsync(FileUpload fileUpload);

        /// <summary>
        /// Deletes the specified file.
        /// </summary>
        /// <param name="fileKey">The unique key of the file to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task<Result> DeleteFileAsync(string fileKey);
    }

}
