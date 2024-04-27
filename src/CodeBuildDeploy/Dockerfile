FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
# Turn off Invariant mode and install icu packages for EntityFramework. 
# See: https://github.com/dotnet/SqlClient/issues/220
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS sdkbase
# Turn off Invariant mode and install icu packages for EntityFramework. 
# See: https://github.com/dotnet/SqlClient/issues/220
RUN apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
RUN curl -L https://raw.githubusercontent.com/Microsoft/artifacts-credprovider/master/helpers/installcredprovider.sh  | sh
ARG FEED_ACCESSTOKEN
ENV VSS_NUGET_EXTERNAL_FEED_ENDPOINTS="{\"endpointCredentials\": [{\"endpoint\":\"https://markpollard.pkgs.visualstudio.com/CodeBuildDeploy/_packaging/CodeBuildDeploy/nuget/v3/index.json\", \"username\":\"docker\", \"password\":\"${FEED_ACCESSTOKEN}\"}]}"
ARG BUILD_CONFIGURATION=Release
ARG VERSION=0.0.0-local
ARG ASSEMBLY_VERSION=0.0.0
ARG FILE_VERSION=0.0.0.0
ARG INFORMATIONAL_VERSION=0.0.0-local
ARG PACKAGE_VERSION=0.0.0-local
WORKDIR /work

FROM sdkbase AS build
WORKDIR /work
COPY ["src/CodeBuildDeploy/CodeBuildDeploy.csproj", "src/CodeBuildDeploy/"]
COPY ["src/CodeBuildDeploy.DataAccess/CodeBuildDeploy.DataAccess.csproj", "src/CodeBuildDeploy.DataAccess/"]
COPY ["./nuget.config", "./"]
RUN dotnet restore "./src/CodeBuildDeploy/CodeBuildDeploy.csproj"
COPY . .
WORKDIR "/work/src/CodeBuildDeploy"
RUN dotnet build "./CodeBuildDeploy.csproj" --no-restore -p:Version=${VERSION} -p:AssemblyVersion=${ASSEMBLY_VERSION} -p:FileVersion=${FILE_VERSION} -p:InformationalVersion=${INFORMATIONAL_VERSION} -p:PackageVersion=${PACKAGE_VERSION} -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
WORKDIR "/work/src/CodeBuildDeploy"
RUN dotnet publish "./CodeBuildDeploy.csproj" --no-build -p:OutDir=/app/build -p:Version=${VERSION} -p:AssemblyVersion=${ASSEMBLY_VERSION} -p:FileVersion=${FILE_VERSION} -p:InformationalVersion=${INFORMATIONAL_VERSION} -p:PackageVersion=${PACKAGE_VERSION} -c $BUILD_CONFIGURATION -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodeBuildDeploy.dll"]