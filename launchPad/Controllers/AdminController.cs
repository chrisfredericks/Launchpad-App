using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using launchPad.Models;

namespace launchPad.Controllers
{
    public class AdminController : Controller {

        // // injecting the DbContext object into this controller for use! No more construction needed :)
        // private LinkManager linkManager;
        // public AdminController(LinkManager myManager) {
        //     linkManager = myManager;
        // }

        public IActionResult Start() { 
            LinkManager linkManager = new LinkManager();
            // add this on top of every action method that needs user authentication
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            }
            linkManager.getCategories();
            Console.WriteLine("\n\n*****Category: " + linkManager.categories[0].category);
            Console.WriteLine("\n\n*****Category: " + linkManager.categories[1].category);
            Console.WriteLine("\n\n*****Category: " + linkManager.categories[2].category);
            Console.WriteLine("\n\n*****Category: " + linkManager.categories[3].category);
            return View(linkManager);
        }
    }
}
