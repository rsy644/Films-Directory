using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        // When you browse to the app and don't supply any URL segments, it defaults to the "Home" controller
        // and the "Index" method specified in the template line highlighted above.

        // First part of the URL determines the controller class to run.
        // Second URL part determines the action method on the class. So localhost:{PORT}/HelloWorld/Index would
        // cause the Index method of the HelloWorldController class to run.

        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}