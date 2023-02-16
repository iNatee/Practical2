using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practical2.Pages
{
    [BindProperties]
    public class ReceiveDetailsModel : PageModel
    {

        public string? Title{get; set;}
        public string? Name{get; set;}
        public void OnGet()
        {
        }

        public void OnPost() {
            ViewData["NameLabel"] = $"Thank You {Title} {Name}";
        }
    }
}
