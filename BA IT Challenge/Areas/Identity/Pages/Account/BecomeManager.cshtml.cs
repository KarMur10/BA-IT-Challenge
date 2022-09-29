using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace BA_IT_Challenge.Areas.Identity.Pages.Account
{
    public class BecomeManagerModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private IHttpContextAccessor _HttpContextAccessor;
        public BecomeManagerModel(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _HttpContextAccessor = httpContextAccessor;
        }
        public async Task OnGet()
        {
            if (!await _roleManager.RoleExistsAsync("Manager"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Manager"));
            }

            var user = _HttpContextAccessor.HttpContext?.User;
            var identityUser = await _userManager.GetUserAsync(user);

            await _userManager.AddToRoleAsync(identityUser, "Manager");
            await _userManager.AddClaimAsync(identityUser, new Claim(ClaimTypes.Role, "Manager"));
        }
    }
}