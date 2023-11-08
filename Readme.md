# Code Build Deploy Blog Website

The Code Build Deploy Website and Blog (https://www.codebuilddeploy.com / https://www.codebuilddeploy.co.uk).

The Site is deployed to Azure App Services.

[[_TOC_]]

## Building

```bash
dotnet build
```

## Publishing

```bash
dotnet publish ./CodeBuildDeploy/CodeBuildDeploy.csproj -v n --framework net6.0 --self-contained:false --no-restore -o ./publish/net6.0
```

## Running

```bash
 dotnet run ./CodeBuildDeploy/CodeBuildDeploy.csproj
```