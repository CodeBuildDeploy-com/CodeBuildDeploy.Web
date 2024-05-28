[[_TOC_]]

# Code Build Deploy Blog Website

The Code Build Deploy Website (https://www.codebuilddeploy.com / https://www.codebuilddeploy.co.uk).

The site is deployed as a container, into [AKS](https://azure.microsoft.com/en-gb/products/kubernetes-service/).

[![Build Status](https://markpollard.visualstudio.com/CodeBuildDeploy/_apis/build/status%2FCodeBuildDeploy.Web?branchName=master)](https://markpollard.visualstudio.com/CodeBuildDeploy/_build/latest?definitionId=4&branchName=master)

# Standard DotNet Build

## Building

```bash
dotnet build
```

## Publishing

```bash
dotnet publish ./CodeBuildDeploy.Web/CodeBuildDeploy.Web.csproj --framework net8.0 --self-contained:false --no-restore -o ./publish
```

## Running

```bash
 dotnet run ./CodeBuildDeploy.Web/CodeBuildDeploy.Web.csproj
```

# Docker Build

## Generate Devcert

```powershell
dotnet dev-certs https -ep "$env:USERPROFILE\.aspnet\https\code-build-deploy.pfx" -p SOME_PASSWORD
dotnet dev-certs https --trust
```

## Configure the environment variable
Create a .env file based on the .env.example
```bash
FEED_ACCESSTOKEN=Access_Token_To_AzureDevOps_Feeds
CERT_PASSWORD=SOME_PASSWORD
ASPNETCORE_ENVIRONMENT=Development
```

## Building and Running

```powershell
docker compose up -d --build
```