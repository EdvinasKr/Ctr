using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshop.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Uzsakymas()
        {
            return PartialView();
        }

        public ActionResult Prekes()
        {
            return PartialView();
        }

        public ActionResult PridetiNauja()
        {
            return PartialView();
        }
    }
}