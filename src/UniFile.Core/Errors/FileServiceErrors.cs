using FluentResults;

namespace UniFile.Core.Errors
{
    /// <summary>
    /// Represents error messages related to file management operations.
    /// </summary>
    public static class FileServiceError
    {
        public static Error NotFound(string fileKey) =>
            new Error($"File with key '{fileKey}' was not found.")
                .WithMetadata("ErrorCode", "FileNotFound");

        public static Error CreationFailed() =>
            new Error("Failed to create the file.")
                .WithMetadata("ErrorCode", "FileCreationFailed");

        public static Error DeletionFailed(string fileKey) =>
            new Error($"Failed to delete the file with key '{fileKey}'.")
                .WithMetadata("ErrorCode", "FileDeletionFailed");
        public static Error InvalidOperation() =>
            new Error("Invalid operation on file.")
                .WithMetadata("ErrorCode", "InvalidFileOperation");
    }

}
