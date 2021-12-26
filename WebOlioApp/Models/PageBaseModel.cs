using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebOlioApp.Models
{
    public abstract class PageBaseModel : PageModel
    {
        public string Title { get; set; }
    }
}