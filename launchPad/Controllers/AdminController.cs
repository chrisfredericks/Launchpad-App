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

        // injecting the DbContext object into this controller for use! No more construction needed :)
        private LinkManager linkManager;
        public AdminController(LinkManager myManager) {
            linkManager = myManager;
        }

        public IActionResult Start() { 
            // add this on top of every action method that needs user authentication
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            } 
            return View(linkManager);
        }
    }
}
