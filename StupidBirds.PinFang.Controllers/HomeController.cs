﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using StupidBirds.PinFang.Models;

namespace StupidBirds.PinFang.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View(new HomePageModel());
        }
    }
}
