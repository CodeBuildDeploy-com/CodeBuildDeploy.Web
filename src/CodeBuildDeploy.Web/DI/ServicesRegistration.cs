using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodeBuildDeploy.Web.DI
{
    public static class ServicesRegistration
    {
        private const string AuthCookieName = ".AspNet.AuthCookie";

        public static IServiceCollection ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var dataProtectionBuilder = services.AddDataProtection().SetApplicationName("CodeBuildDeploy");
            var azureStorageDataProtectionSection = configuration.GetSection("Authentication:DataProtection:AzureStorage");
            if (azureStorageDataProtectionSection.Exists())
            {
                dataProtectionBuilder.PersistKeysToAzureBlobStorage(
                    azureStorageDataProtectionSection["ConnectionString"],
                    azureStorageDataProtectionSection["ContainerName"],
                    azureStorageDataProtectionSection["BlobName"]);
            }

            services.AddAuthentication(IdentityConstants.ApplicationScheme)
                    .AddCookie(IdentityConstants.ApplicationScheme, o =>
                    {
                        o.Cookie.Name = AuthCookieName;
                        o.Cookie.Path = "/";
                        o.LoginPath = new PathString("/Account/Login");
                    });

            return services;
        }
    }
}
