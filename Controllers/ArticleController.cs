using Microsoft.AspNetCore.Mvc;
using System.Text;
using WAF.API;
using WAF.API.Web;
using WAF.Engine.Content;
using WAF.Engine.Content.Native;

namespace App.ServerCore.Controllers {

    public class ArticleController : Controller {
        WAFNativeContext _ctx;
        public ArticleController(WAFNativeContext ctx) {
            _ctx = ctx;
        }
        public IActionResult Index() {
            var c = _ctx.Request.GetContent<ArticleBase>();
            return View(c);
        }
    }
}