using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using launchPad.Models;
using userAuthentication.Models;

namespace launchPad.Controllers
{
    public class HomeController : Controller {

        // injecting the DbContext object into this controller for use! No more construction needed :)
        private LinkManager linkManager;
        public HomeController(LinkManager myManager) {
            linkManager = myManager;
        }

        public IActionResult Index() {
            
            return View(linkManager);
        }
    }
}
