﻿using System.Web.Mvc;

namespace EshopMain.Controllers
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