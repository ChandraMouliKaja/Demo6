using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Demo6.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Demo6.Controllers
{
    public class JobController : Controller
    {
        //private readonly RegisterationRepositry registerationRepositry;
        //public JobController()
        //{
        //    registerationRepositry = new RegisterationRepositry();           
        //}

        [HttpGet]
        public IActionResult AddDetails()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult DisplayDetails(Registeration registeration)
        {
            if (ModelState.IsValid)
            {
                //Registeration data = registerationRepositry.Add(registeration);
                return View(registeration);
            }          
                return View("AddDetails");                
        }
      //[HttpPost]
      //  public PartialViewResult Details2(Registeration registeration)
      //  {
      //      return PartialView("_Details1",registeration);
      //  }
       
        //public ContentResult AboutUs()
        //{
        //    return Content("Welcome. You Can Apply to this Job using " +
        //        "New Job Application in the Home Page");
        //}

       
    }
}
