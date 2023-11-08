using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CodeBuildDeploy.Pages.Home;

public class AboutModel : PageModel
{
    private readonly ILogger<AboutModel> _logger;

    [ViewData]
    public string Title { get; } = "About Me";

    [ViewData]
    public string Message { get; } = "All about me..";

    public AboutModel(ILogger<AboutModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
