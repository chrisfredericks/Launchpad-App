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
                return RedirectToAction("Index", "Login");
            } 
            return View(linkManager);
        }

        public IActionResult Add(int id) {
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            } 
            Category cat = linkManager.getCategory(id);
            ViewBag.catId = id;
            ViewBag.catName = cat.category; 
            Link link = new Link();
            return View(link);
        }

        [HttpPost]
        public IActionResult AddSubmit(Link link) {
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            } 
            if (!ModelState.IsValid) return RedirectToAction("Index", linkManager); 
            
            if (link.pinned == null) {
                link.pinned = "0";
            } else {
                link.pinned = "1";
            } 

            linkManager.Add(link);
            linkManager.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int selectedCatId) {
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            } 
            Category cat = new Category();
            cat = linkManager.populateEditCategory(selectedCatId);
            return View(cat);
        }
        
        [HttpPost]
        public IActionResult UpdateSubmit(Category cat) {
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            } 
            if (!ModelState.IsValid) return RedirectToAction("Index", linkManager); 
            linkManager.Update(cat);
            linkManager.SaveChanges();
 
            return RedirectToAction("Index", linkManager); 
        }

        public IActionResult UpdateLink(int selectedLinkId) {
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            } 
            Link link = new Link();
            // save the SelectList object in the view bag for use on the view
            List<Category> categories= linkManager.getList();
            ViewBag.selectList = new SelectList(categories, "Id", "category");
            link = linkManager.populateEditLink(selectedLinkId);

            return View(link);
        }

        [HttpPost]
        public IActionResult UpdateLinkSubmit(Link link) {
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            } 
            if (link.pinned == null) {
                link.pinned = "0";
            } else {
                link.pinned = "1";
            } 
            if (!ModelState.IsValid) return RedirectToAction("Index", linkManager);

            linkManager.Update(link);
            linkManager.SaveChanges();
 
            return RedirectToAction("Index", linkManager); 
        }
        
        public IActionResult Delete(int delSelectedLink) {
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            } 
            Link link = new Link();
            link = linkManager.populateDeleteLink(delSelectedLink);

            return View(link);
        }

        [HttpPost]
        public IActionResult DeleteSubmit(int delSelectedLink) {
            if (HttpContext.Session.GetString("auth") != "true") {
                return RedirectToAction("Index", "Login");
            } 
            Link link = new Link();
            link = linkManager.populateDeleteLink(delSelectedLink);

            linkManager.Remove(link);
            linkManager.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
