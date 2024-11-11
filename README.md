---

# UniFile

UniFile is a flexible file management solution for .NET applications, providing a core interface for CRUD operations on files. 
This package supports custom implementations for file storage backends and includes robust error handling using `FluentResults`.

## Features

- **File CRUD Operations**: Easily create, read, update, and delete files.
- **Flexible Configuration**: Customize storage locations and settings with fluent configuration.
- **Error Handling**: Structured error responses with metadata for improved debugging.

## Solution Strucutre 
```
UniFile/
├── src/
│   ├── UniFile.Core/
│   │   ├── Service/
│   │   │   ├── IFileService.cs
│   │   │   ├── IFileHeaderService.cs
│   │   │   
│   │   ├── Abstraction/
│   │   │   ├── FileHeader.cs
│   │   │   ├── FileUpload.cs
│   │   │
│   │   ├── Errors/
│   │   │   ├── FileServiceError.cs
│   │   │   ├── FileHeaderServiceError.cs
│   │   │   ├── FileErrors.cs
│   │   │   
│   │   ├── UniFile.Core.csproj
│   │
│   ├── UniFile.Infrastructure.FileSystem/ (To Do)
│   │   ├── Configuration/
│   │   │   ├── FileSystemOptions.cs
│   │   ├── Services/
│   │   │   ├── FileSystemFileService.cs
│   │   │   ├── FileSystemFileHeaderService.cs
│   │   ├── UniFile.Infrastructure.FileSystem.csproj
│   │
│   ├──Samples /
│   │   ├── Web Sample/
│   │   │   ├── Controllers/
│   │   │   │   ├── FileController.cs
│   │   │   ├── Program.cs
│   │   │   ├── Startup.cs
│   │   │   ├── webSample.csproj
│
├── tests/
│   ├── UniFile.Core.Tests/ (To Do)
│   │   ├── FileServiceTests.cs
│   │   ├── FileHeaderServiceTests.cs
│   │   ├── UniFile.Core.Tests.csproj
│   │
│   ├── UniFile.Infrastructure.FileSystem.Tests/
│   │   ├── FileSystemFileServiceTests.cs
│   │   ├── UniFile.Infrastructure.FileSystem.Tests.csproj
│
├── README.md
├── UniFile.sln
```
## Installation

Add UniFile to your .NET project by installing the package via NuGet:
```bash
dotnet add package UniFile
```

## Quick Start

### 1. Register the File Service (To Do)


### 2. Use the File Management Service (To DO)


## Roadmap

- **Additional Storage Backends**: Future releases will include options for cloud and database storage.
- **Enhanced Configuration Options**: Additional configuration options to set from appsettings.json.

## Contributing

Feel free to contribute! Fork the repo, make your changes, and submit a pull request. 

## License

UniFile is released under the MIT License.

---
