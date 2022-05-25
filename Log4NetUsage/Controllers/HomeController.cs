using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Log4NetUsage.LoggerManager;
namespace Log4NetUsage.Controllers
{
    public class HomeController : Controller
    {

        LoggerManager logger = new LoggerManager();
        // GET: Home
        public ActionResult Index()
        {
          
            logger.Info("Index-page started...");
            return View();
        }
    }
}