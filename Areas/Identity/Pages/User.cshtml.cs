using asp_net_core_web_app_authentication_authorisation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_net_core_web_app_authentication_authorisation.Areas.Identity.Pages
{
    [Authorize]
    public class UserModel : PageModel
    {
        private UserManager<ApplicationUser> UserManager { get; set; }
        public ApplicationUser? appUser;

        public UserModel(UserManager<ApplicationUser> userManager)
        {
            UserManager = userManager;
        }

        public void OnGet()
        {
            var userTask = UserManager.GetUserAsync(User);
            userTask.Wait();

            appUser = userTask.Result;
        }
    }
}
