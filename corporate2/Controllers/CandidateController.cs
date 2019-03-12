using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using corporate2.Data.Models;
using corporate2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;


namespace corporate2.Controllers
{
    public class CandidateController : Controller
    {

        //[Route("/Candidate/CandidatePage")]
        DataContext db = new DataContext();
       // HttpContext context;
        private readonly IHostingEnvironment he;
        public CandidateController(IHostingEnvironment e)
        {
            he = e;
        }
        
        [HttpGet]
        public IActionResult CandidatePage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CandidatePage(DataFile fileSave, Candidate candidate, IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    fileSave.Path = "No File Exist";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot" + "/Files/", Path.GetFileName(file.FileName));
                    file.CopyTo(new FileStream(path, FileMode.Create));
                    // var stream = new FileStream(path, FileMode.Create);
                    fileSave.Path = "/" + Path.GetFileName(file.FileName);
                    fileSave.Extension = Path.GetExtension(file.FileName);
                    //fileSave.Filename = file.ContentType;
                }
            }
            catch(Exception e)
            {
                
                ViewBag.Meassage = e;
            }
            db.Candidate.Add(candidate);
            db.DataFile.Add(fileSave);
            ViewData["Result"]=db.SaveChanges();
           /* if(i==1)
            {
                // context.Response.WriteAsync("<h1>Data Inserted Scussfully</h1>");
                //ViewBag.Mesaage = "Data Inserted Scussfully";
                //return View();
                return RedirectToAction(nameof(CandidatePage));
            }*/
            return View();
        }

    }

}

       

    

