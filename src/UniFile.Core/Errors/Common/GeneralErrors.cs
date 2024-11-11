using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniFile.Core.Errors.Common
{
    public static class GeneralErrors
    {

        public static Error UnexpectedError() =>
            new Error("An unexpected error occurred. Please try again later.")
                .WithMetadata("ErrorCode", "General_UnexpectedError");

        public static Error InvalidData() =>
            new Error("The provided data is invalid.")
                .WithMetadata("ErrorCode", "General_InvalidData");
    }
}
