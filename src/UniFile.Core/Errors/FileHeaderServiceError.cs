using FluentResults;

namespace UniFile.Core.Errors
{
    /// <summary>
    /// Represents error messages related to file header management operations.
    /// </summary>
    public static class FileHeaderServiceError
    {
        public static Error NotFound(string fileKey) =>
            new Error($"File header with key '{fileKey}' was not found.")
                .WithMetadata("ErrorCode", "FileHeaderNotFound");

        public static Error CreationFailed() =>
            new Error("Failed to create the file header.")
                .WithMetadata("ErrorCode", "FileHeaderCreationFailed");

        public static Error MetadataUpdateFailed(string fileKey) =>
            new Error($"Failed to update metadata for file header with key '{fileKey}'.")
                .WithMetadata("ErrorCode", "FileMetadataUpdateFailed");

        public static Error InvalidOperation() =>
            new Error("Invalid operation on file header.")
                .WithMetadata("ErrorCode", "InvalidFileHeaderOperation");
    }

}
