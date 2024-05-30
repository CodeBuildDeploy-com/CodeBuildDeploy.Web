using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace CodeBuildDeploy.Web.DI
{
    public static class ServicesRegistration
    {
        private const string AuthCookieName = ".AspNet.AuthCookie";

        public static IServiceCollection ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var dataProtectionBuilder = services.AddDataProtection().SetApplicationName("CodeBuildDeploy");
            var keysPathSection = configuration.GetSection("Authentication:DataProtection:KeysPath");
            if (keysPathSection.Exists())
            {
                dataProtectionBuilder.PersistKeysToFileSystem(new DirectoryInfo(keysPathSection.Value!));
            }

            services.ConfigureApplicationCookie(options => {
                options.Cookie.Name = AuthCookieName;
                options.Cookie.Path = "/";
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                                      .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme);

            return services;
        }
    }
}
