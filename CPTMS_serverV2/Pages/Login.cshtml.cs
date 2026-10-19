using CPTMS_serverV2.Modules.Login.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using CPTMS_serverV2.Modules.Login;

namespace CPTMS_serverV2.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "用户名不能为空")]
        [Display(Name = "用户名")]
        public string? Username { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "密码不能为空")]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string? Password { get; set; }

        private readonly IAuthService _authService;
        public LoginModel(IAuthService authService)
        {
            _authService = authService;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page(); //Required的值不成立，不继续后续逻辑
            
            var request = new LoginRequest(Username!, Password!);
            var result = await _authService.LoginAsync(request);

            if (result.IsSuccess)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Username!)
                };
                foreach(var i in result.Roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, i.ToString()));
                }

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                if (result.Roles.Contains(Role.Teacher)) return RedirectToPage("/Teacher");
                if (result.Roles.Contains(Role.Student)) return RedirectToPage("/Student");
            }
            else
            {
                //ModelState.AddModelError(string.Empty, "用户名或密码错误");
                //ModelState.AddModelError(string.Empty, "服务器内部错误，请稍后再试");
                ModelState.AddModelError(string.Empty, result.ErrorMessage ?? "");
                return Page();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToPage("/Login");
        }
    }
}
