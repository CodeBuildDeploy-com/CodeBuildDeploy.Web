﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;

namespace CodeBuildDeploy.Areas.Identity.Pages.Account
{
    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
    }
}