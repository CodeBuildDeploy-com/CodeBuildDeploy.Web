[[_TOC_]]

# Code Build Deploy Blog Website

The Code Build Deploy Website and Blog (https://www.codebuilddeploy.com / https://www.codebuilddeploy.co.uk).

The site is deployed to [Azure App Services](https://azure.microsoft.com/en-gb/products/app-service).

# Standard DotNet Build

## Building

```bash
dotnet build
```

## Publishing

```bash
dotnet publish ./CodeBuildDeploy/CodeBuildDeploy.csproj -v n --framework net8.0 --self-contained:false --no-restore -o ./publish/net8.0
```

## Running

```bash
 dotnet run ./CodeBuildDeploy/CodeBuildDeploy.csproj
```

# Docker Build

## Building

```powershell
. .\build.ps1
```

## Publishing

```powershell
docker push codebuilddeploy.azurecr.io/code-build-deploy:latest
```

## Pulling

```powershell
docker pull codebuilddeploy.azurecr.io/code-build-deploy:latest
```

## Running

```powershell
. .\run.ps1
```