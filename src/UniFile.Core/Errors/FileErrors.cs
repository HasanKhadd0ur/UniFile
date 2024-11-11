using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniFile.Core.Errors
{
    public static class  FileErrors
    {
        public static Error NotFound(string fileKey) =>
                       new Error($"File with key '{fileKey}' was not found.")
                           .WithMetadata("ErrorCode", "File_NotFound");

        public static Error InvalidFormat(string fileName) =>
            new Error($"File '{fileName}' has an invalid format.")
                .WithMetadata("ErrorCode", "File_InvalidFormat");

        public static Error AccessDenied(string fileKey) =>
            new Error($"Access to file with key '{fileKey}' was denied.")
                .WithMetadata("ErrorCode", "File_AccessDenied");

        public static Error StorageFailure() =>
            new Error("An error occurred while accessing the file storage.")
                .WithMetadata("ErrorCode", "File_StorageFailure");

    }
}
