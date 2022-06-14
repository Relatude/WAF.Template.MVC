using App.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WAF.API.Native.API.Web;

namespace App.Server.Controllers {
    public class LoginController : Controller {
        
        private readonly SignInManager<WAFIdentityUser> _signInManager;

        public LoginController(SignInManager<WAFIdentityUser> signInManager) {
            _signInManager = signInManager;            
        }
        [HttpGet]
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model) {
            if (ModelState.IsValid) {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, true, false);
                if (result.Succeeded) {
                    return Redirect("/");                
                } else
                    ModelState.AddModelError("LoginError", "Invalid username or password");
            }    
            return View(model);
        }

        public async Task<IActionResult> Logout() {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }         
    }
}
