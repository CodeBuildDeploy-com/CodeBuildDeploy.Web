using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using CodeBuildDeploy.Models;

namespace CodeBuildDeploy.Pages.Shared;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class NotFoundModel : ErrorModelBase
{
    private readonly ILogger<NotFoundModel> _logger;

    [ViewData]
    public string Title { get; } = "NotFound";

    public NotFoundModel(ILogger<NotFoundModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
    }
}

