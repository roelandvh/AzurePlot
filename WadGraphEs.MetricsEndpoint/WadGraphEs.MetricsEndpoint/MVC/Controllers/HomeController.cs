﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WadGraphEs.MetricsEndpoint.MVC.Controllers {
    public class HomeController : Controller{
        [Authorize]
        public ActionResult Index() {
            return Content("ok");
        }
    }
}