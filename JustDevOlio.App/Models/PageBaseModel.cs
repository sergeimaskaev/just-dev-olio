using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JustDevOlio.App.Models
{
    public abstract class PageBaseModel : PageModel
    {
        public string Title { get; set; }
    }
}