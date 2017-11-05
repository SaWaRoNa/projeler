using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace WebApiClient.Controllers
{
    public class HomeController : Controller
    {
        [EnableCorsAttribute("*", "*", "*")]
        public ActionResult Index()
        {
                       return View();
        }
    }
}
