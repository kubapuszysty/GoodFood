using GoodFood.web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodFood.web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            //var name = HttpContext.Request.QueryString["name"]; //usually pass a variable in Index()
            model.Name = name ?? "there's no name";
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}