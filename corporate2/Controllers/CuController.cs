﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace corporate2.Controllers
{
    public class CuController : Controller
    {
        public IActionResult Cu()
        {
            return View();
        }
    }
}