﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BMTGroup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();
    }
}