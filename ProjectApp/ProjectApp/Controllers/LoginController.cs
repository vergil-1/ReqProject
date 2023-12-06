using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjectApp.Controllers
{
    [OutputCache(Duration = 0, NoStore = true)]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated == true)
            {
                FormsAuthentication.RedirectFromLoginPage(User.Identity.Name, false);
            }
            return View();
        }
        [HttpPost]
        public ActionResult TryLogin(string email, string password)
        {
            FormsAuthentication.RedirectFromLoginPage(email, false);
            return new EmptyResult();
        }
    }
}