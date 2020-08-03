using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string Index()
        {
            return @"<strong>Hello World as a string from Index</strong>";
        }

        // GET: /test/play
        [HttpGet]
        public string Play()
        {
            // Return a string as a view
            return @"<strong>Hello World as a string from Play</strong>";
        }

        // GET: /Test/TestView 
        [HttpGet]

        public ActionResult TestView()
        {
            // Return a 'TestView.cshtml" (View maps to Action method name)
            return View();
        }
    }
}