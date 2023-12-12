using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_net_core_web_app_authentication_authorisation.Areas.Identity.Pages
{
    [Authorize(Roles = "client")]
    public class ClientModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
