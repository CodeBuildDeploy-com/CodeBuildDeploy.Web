using System;
using Microsoft.AspNetCore.Identity;

namespace MyWebSite.DataAccess
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual DateTime LastLoginTime { get; set; }
        public virtual DateTime RegistrationDate { get; set; }
    }
}