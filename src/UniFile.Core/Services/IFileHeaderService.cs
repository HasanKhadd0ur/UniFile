using System.Threading.Tasks;
using UniFile.Core.Abstraction;
using FluentResults;
using System.Collections.Generic;

namespace UniFile.Core.Services
{
    /// <summary>
    /// Provides operations for managing file headers, including creation, retrieval, and metadata updates.
    /// </summary>
    public interface IFileHeaderService
    {
        /// <summary>
        /// Creates a new file header and associates it with a unique key.
        /// </summary>
        /// <param name="fileHeader">The file header to create.</param>
        /// <returns>A task representing the asynchronous operation, containing the result of the creation operation.</returns>
        Task<Result<FileHeader>> CreateFileHeaderAsync(FileHeader fileHeader);

        /// <summary>
        /// Retrieves a file header based on the specified file key.
        /// </summary>
        /// <param name="fileKey">The unique key of the file header to retrieve.</param>
        /// <returns>A task representing the asynchronous operation, containing the file header if found.</returns>
        Task<Result<FileHeader>> GetFileHeaderAsync(string fileKey);

        /// <summary>
        /// Updates the metadata of an existing file header.
        /// </summary>
        /// <param name="fileKey">The unique key of the file header to update.</param>
        /// <param name="metadata">The new metadata to associate with the file header.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task<Result> UpdateFileMetadataAsync(string fileKey, Dictionary<string, string> metadata);
    }
}
