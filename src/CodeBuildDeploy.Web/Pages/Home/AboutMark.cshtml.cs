using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CodeBuildDeploy.Pages.Home;

public class AboutMarkModel : PageModel
{
    private readonly ILogger<AboutMarkModel> _logger;

    [ViewData]
    public string Title { get; } = "About Mark Pollard";

    [ViewData]
    public string Message { get; } = "The founder of Code Build Deploy..";

    public AboutMarkModel(ILogger<AboutMarkModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
