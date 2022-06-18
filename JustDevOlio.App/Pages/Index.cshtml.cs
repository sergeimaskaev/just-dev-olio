using JustDevOlio.App.Models;
using JustDevOlio.App.Models.View;

namespace JustDevOlio.App.Pages
{
    public class IndexModel : PageBaseModel
    {
        private IndexCard[] _cards = new IndexCard[]
        {
            new()
            {
                Title="Notes",
                Description="Fast notes using Markdown",
                Url = "/Notes/Index"
            }
        };

        public IndexCard[] Cards => _cards;

        public void OnGet()
        {

        }
    }
}
