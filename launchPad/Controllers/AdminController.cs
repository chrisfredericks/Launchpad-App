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

        public IActionResult Index() { 
            // add this on top of every action method that needs user authentication
            if (HttpContext.Session.GetString("auth") != "true") {
                Console.WriteLine("\n\n Log out???? \n\n");
                return RedirectToAction("Index", "Login");
            } 
            return View(linkManager);
        }


        public IActionResult Add(int id) {
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            } 
            Console.WriteLine("\n\n*****categoryId: " + id);
            Category cat = linkManager.getCategory(id);
            Console.WriteLine("\n\n*****category: " + cat.category);
            ViewBag.catId = id;
            ViewBag.catName = cat.category; 
            Link link = new Link();
            return View(link);
        }

        [HttpPost]
        public IActionResult AddSubmit(Link link) {
            // if (HttpContext.Session.GetString("auth") != "true") {
            //     return RedirectToAction("Index", "Login");
            // } 
            // if (!ModelState.IsValid) return RedirectToAction("Index", linkManager);

            linkManager.Add(link);
            linkManager.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int selectedCatId) {
            Category cat = new Category();
            cat = linkManager.populateEditCategory(selectedCatId);
            return View(cat);
        }
        
        [HttpPost]
        public IActionResult UpdateSubmit(Category cat) {

            linkManager.Update(cat);
            linkManager.SaveChanges();
 
            return RedirectToAction("Index", linkManager);
        }
    }
}
