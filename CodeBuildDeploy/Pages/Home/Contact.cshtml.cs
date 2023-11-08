using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CodeBuildDeploy.Pages.Home;

public class ContactModel : PageModel
{
    private readonly ILogger<ContactModel> _logger;

    [ViewData]
    public string Title { get; } = "Contact";

    [ViewData]
    public string Message { get; } = "Get in touch...";

    public ContactModel(ILogger<ContactModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
