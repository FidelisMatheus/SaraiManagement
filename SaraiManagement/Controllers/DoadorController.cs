﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Controllers
{
    public class DoadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
