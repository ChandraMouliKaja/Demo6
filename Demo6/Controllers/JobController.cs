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
                return View(registeration);
            }          
                return View("AddDetails");                
        }
      
        public ContentResult AboutUs()
        {
            return Content("Welcome. To apply for the job click on New Job Application in the Home Page");
        }


    }
}
