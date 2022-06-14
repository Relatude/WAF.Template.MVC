using App.Server.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WAF.API.Web;
using WAF.Engine.Content.Native;

namespace App.Server.Controllers {
    public class AccountController : Controller {
        WAFControllerContext _ctx;
        public AccountController(WAFControllerContext ctx) {
            _ctx = ctx;
        }
        public async Task<IActionResult> Login(LoginModel? login) {
            if (login == null || login.UserName == null) return View();
            var clientAddress = HttpContext.Connection.RemoteIpAddress?.ToString();

            if (_ctx.Engine.TryLogInSession(_ctx.Session, login.UserName, login.Password, clientAddress, 
                null, null, out var failureReson, out var meta, out var code, out var deviceKey)) {

                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, _ctx.Session.UserName));
                var identity = new ClaimsIdentity(claims, _ctx.Config.AuthenticationSchemaName);
                var claimsPrinciple = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(_ctx.Config.AuthenticationSchemaName, claimsPrinciple);

            }

            return View(null, failureReson.ToString());
        }
    }
}
