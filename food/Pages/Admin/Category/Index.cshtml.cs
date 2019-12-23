using food.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace food.Pages.Admin.Category
{
    [Authorize(Roles=SD.ManagerRole)]


    public class IndexModel : PageModel
    {
        
        public void OnGet()
        {

        }
    }
}