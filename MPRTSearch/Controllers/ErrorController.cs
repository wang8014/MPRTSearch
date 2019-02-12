using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MPRTSearch.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        [AllowAnonymous]
        public ActionResult Index()
        {
            Exception e = new Exception("Invalid Controller or/and Action Name");
            HandleErrorInfo eInfo = new HandleErrorInfo(e, "Unknown", "Unknown");
            if(!System.IO.Directory.Exists(Request.PhysicalApplicationPath + "//Error"))
            {
                System.IO.Directory.CreateDirectory(Request.PhysicalApplicationPath + "//Error");
            }
            return View("Error", eInfo);
        }
        // GET: Error
        [AllowAnonymous]
        public ActionResult DefaultIndex()
        {
            Exception e = new Exception("okänd fel, kontakta personalen");
            HandleErrorInfo eInfo = new HandleErrorInfo(e, "Unknown", "Unknown");
            if (!System.IO.Directory.Exists(Request.PhysicalApplicationPath + "//Error"))
            {
                System.IO.Directory.CreateDirectory(Request.PhysicalApplicationPath + "//Error");
            }
            return View("Error", eInfo);
        }
    }
}