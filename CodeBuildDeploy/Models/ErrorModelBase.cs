using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeBuildDeploy.Models
{
    public class ErrorModelBase : PageModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
