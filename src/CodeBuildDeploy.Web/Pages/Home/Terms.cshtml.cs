using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CodeBuildDeploy.Pages.Home;

public class TermsModel : PageModel
{
    private readonly ILogger<TermsModel> _logger;

    [ViewData]
    public string Title { get; } = "Privacy Policy";

    public TermsModel(ILogger<TermsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
