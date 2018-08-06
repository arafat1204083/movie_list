using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
            public ActionResult Index()
            {
            return View();
            }

        // GET: Welcome
        public ActionResult Welcome(string name= "user", int id = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.id = "Your id is "+id;

            return View();
        }
        // GET: Welcome with parameter
        /*public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        } */


        /*
        // localhost:XXX/HelloWorld/Welcome/Scott/3 for this route
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        } */
    }
}