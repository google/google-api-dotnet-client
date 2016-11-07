#!/bin/bash
# Runs the .NET Core tests locally (Linux).

set -e

# Restore support libraries and tests.
dotnet restore Src/Support/GoogleApis.Core_dotnetcore/project.json --configfile NuGet.Core.Config
dotnet restore Src/Support/GoogleApis_dotnetcore/project.json --configfile NuGet.Core.Config
dotnet restore Src/Support/GoogleApis.Auth_dotnetcore/project.json --configfile NuGet.Core.Config
dotnet restore Src/Support/GoogleApis.Tests_dotnetcore/project.json --configfile NuGet.Core.Config
dotnet restore Src/Support/GoogleApis.Auth.Tests_dotnetcore/project.json --configfile NuGet.Core.Config

# Restore generated libraries and tests.
dotnet restore Src/Generated/Google.Apis.Discovery.v1/project.json --configfile NuGet.Core.Config
dotnet restore Src/GeneratedTests/Discovery.Tests/project.json --configfile NuGet.Core.Config

# Test support libraries.
dotnet test Src/Support/GoogleApis.Tests_dotnetcore/project.json
dotnet test Src/Support/GoogleApis.Auth.Tests_dotnetcore/project.json

# Test generated libraries.
dotnet test Src/GeneratedTests/Discovery.Tests/project.json
