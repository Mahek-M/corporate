using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace corporate2.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult EmailNotification()
        {
            return View();
        }
    }
}