using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]

        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]

        public ActionResult Login(UserModel model)
        {
            SecurityService security = new SecurityService();

            model = new UserModel();

            bool check = security.Authenticate(model);

            if (check == true)
            {
                return View("LoginPassed");
            }
            else
            {
                return View("LoginFailed");
            }
        }
    }
}