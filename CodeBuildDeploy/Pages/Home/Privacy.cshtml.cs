using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CodeBuildDeploy.Pages.Home;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    [ViewData]
    public string Title { get; } = "Privacy Policy";

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
