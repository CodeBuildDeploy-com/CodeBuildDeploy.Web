using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodeBuildDeploy.Web.DI
{
    public static class ServicesRegistration
    {
        public static IServiceCollection ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                                      .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme);

            return services;
        }
    }
}
