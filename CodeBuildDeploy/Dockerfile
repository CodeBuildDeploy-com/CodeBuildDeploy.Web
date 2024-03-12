FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
# Turn off Invariant mode and install icu packages for EntityFramework. 
# See: https://github.com/dotnet/SqlClient/issues/220
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
# Turn off Invariant mode and install icu packages for EntityFramework. 
# See: https://github.com/dotnet/SqlClient/issues/220
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
RUN curl -L https://raw.githubusercontent.com/Microsoft/artifacts-credprovider/master/helpers/installcredprovider.sh  | sh
ARG CBD_FEED_ACCESSTOKEN
ENV VSS_NUGET_EXTERNAL_FEED_ENDPOINTS="{\"endpointCredentials\": [{\"endpoint\":\"https://markpollard.pkgs.visualstudio.com/CodeBuildDeploy/_packaging/CodeBuildDeploy/nuget/v3/index.json\", \"username\":\"docker\", \"password\":\"${CBD_FEED_ACCESSTOKEN}\"}]}"
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CodeBuildDeploy/CodeBuildDeploy.csproj", "CodeBuildDeploy/"]
COPY ["CodeBuildDeploy.DataAccess/CodeBuildDeploy.DataAccess.csproj", "CodeBuildDeploy.DataAccess/"]
COPY ["./nuget.config", "./"]
RUN dotnet restore "./CodeBuildDeploy/CodeBuildDeploy.csproj"
COPY . .
WORKDIR "/src/CodeBuildDeploy"
RUN dotnet build "./CodeBuildDeploy.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CodeBuildDeploy.csproj" -c $BUILD_CONFIGURATION -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeBuildDeploy.dll"]