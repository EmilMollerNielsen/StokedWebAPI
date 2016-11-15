﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokedAPI6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About this website";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact STOKED";

            return View();
        }
    }
}