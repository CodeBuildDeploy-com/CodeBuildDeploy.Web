
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /src
COPY ["CodeBuildDeploy/CodeBuildDeploy.csproj", "CodeBuildDeploy/"]
RUN dotnet restore "CodeBuildDeploy/CodeBuildDeploy.csproj"
COPY . .
WORKDIR "/src/CodeBuildDeploy"
RUN dotnet build "CodeBuildDeploy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodeBuildDeploy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeBuildDeploy.dll"]