using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myfirstAzureWebApp.Controllers
{
    public class TimeController : Controller
    {
        // GET: Time
        public ActionResult Display()
        {
            //string currenttime = DateTime.Now.ToString();
            return View();
        }
    }
}