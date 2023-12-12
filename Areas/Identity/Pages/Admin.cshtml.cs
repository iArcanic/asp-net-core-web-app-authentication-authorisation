using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_net_core_web_app_authentication_authorisation.Areas.Identity.Pages
{
    [Authorize(Roles = "admin")]
    public class AdminModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
