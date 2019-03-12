using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using corporate2.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using corporate2.Data.Models;

namespace corporate2.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();
        public Login l = new Login();
        [Route("")]
        [HttpGet]
        public IActionResult Login() 
        {
            ViewBag.Login = db.Login.ToList();
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                Login usr = db.Login.FirstOrDefault(u => u.Username == login.Username && u.Password == login.Password);
                // db.Login.Add(login);
                // db.SaveChanges();
                if (usr != null)
                {
                   return RedirectToAction(nameof(Requirementpage));
                   
                    //return RedirectToPage("corporate2/Views/Shared/_Layout.cshtml");
                }
                else
                {
                    ModelState.AddModelError("Error", "ID Password is incorrect");
                    //ScriptManage.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                   // return RedirectToAction(nameof(Login));
                    return View();
                }

            }
            // await db.SaveChangesAsync();   
            return View();
        }
        
        [HttpGet]
        public IActionResult Requirementpage()
        {
            return View();
        }
       


       [HttpPost]
      public IActionResult Req(Requirement requirement)
        { 
           db.Require.Add(requirement);
           int i= db.SaveChanges();

            if(i==1)
            {
                ViewBag.Mesage = "Data Inserted Scussfully";
                return RedirectToAction(nameof(Requirementpage));
            }
            else
            {
              
            }
            //return RedirectToAction(nameof(Requirementpage));
            /*if(i==1)
            {
                return RedirectToAction(nameof(Requirementpage));
            }*/
           
            return View();
        }
        
       [HttpPost]
       public IActionResult logout()
        {
            RedirectToAction(nameof(Login));
            return View();
        }
    }
}
