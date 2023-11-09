
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine AS base
# Turn off Invariant mode and install icu packages for EntityFramework. 
# See: https://github.com/dotnet/SqlClient/issues/220
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
# Turn off Invariant mode and install icu packages for EntityFramework. 
# See: https://github.com/dotnet/SqlClient/issues/220
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
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