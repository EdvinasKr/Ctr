﻿using System.Web.Mvc;

namespace EshopMain.Controllers
{
    public class VartotojasController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrekiuListas()
        {
            return PartialView();
        }

        public ActionResult Krepselis()
        {
            return PartialView();
        }
    }
}