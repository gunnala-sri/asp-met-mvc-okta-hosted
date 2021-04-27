using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_OktaHosted.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var userClaims = HttpContext.GetOwinContext().Authentication.User.Claims;
            var claim = userClaims.ToList().FirstOrDefault(c => c.Type == "BC_Identifier");
            var claim1 = userClaims.ToList().FirstOrDefault(c => c.Type == "IsClient");
            var b2cId = claim.Value;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}