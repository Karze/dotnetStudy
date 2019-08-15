using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers {
    public class StudyController : Controller {
        // 
        // GET: /Study/

        public IActionResult Index () {
            return View ();
        }

        // 
        // GET: /Study/Welcome/ 

        public IActionResult Welcome (string Name, int numTimes = 1) {
            ViewData["Message"] = "Hello, " + Name;
            ViewData["NumTimes"] = numTimes;
            
            return View ();
        }
    }
}