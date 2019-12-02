using System;
using Microsoft.AspNetCore.Mvc;
using userAuthentication.Models;


namespace userAuthentication.Controllers {

    public class LoginController : Controller {

        public IActionResult Index() {
            return View();
        } 

        public IActionResult Submit(string myUsername, string myPassword) {
            WebLogin webLogin = new WebLogin("Server=localhost;Database=dotnetcoreSamples;Uid=cfrederi;Pwd=Dexterismypetsname;SslMode=none;", HttpContext);
            webLogin.username = myUsername;
            webLogin.password = myPassword;

            // do I have access?
            if (webLogin.unlock()) {
                //access granted
                return RedirectToAction("Index","Admin");
            } else {
                // access denied
                ViewData["feedback"] = "Incorrect login. Please try again...";
            }
            
            return View("Index");
        }

        public IActionResult Logout() {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        } 

    }
}
