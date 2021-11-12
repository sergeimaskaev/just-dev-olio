using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearningMarkdownApp.Models
{
    public abstract class PageBaseModel : PageModel
    {
        public string Title { get; set; }
    }
}