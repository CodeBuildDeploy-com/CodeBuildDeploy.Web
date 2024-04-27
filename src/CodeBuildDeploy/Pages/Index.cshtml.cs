using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CodeBuildDeploy.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [ViewData]
    public string Title { get; } = "CODE - BUILD - DEPLOY";

    [ViewData]
    public string Message { get; } = "Information source for software engineers and enthusiasts alike.\r\n";

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
