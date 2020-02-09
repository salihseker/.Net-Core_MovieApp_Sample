using Microsoft.AspNetCore.Mvc;
using NetCore_MovieApp.Models;

namespace NetCore_MovieApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Movies);
        }

        public IActionResult Contact()
        {
            return View();
        }
        
        
    }
}