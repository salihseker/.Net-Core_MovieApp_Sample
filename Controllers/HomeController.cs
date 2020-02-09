using Microsoft.AspNetCore.Mvc;

namespace NetCore_MovieApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        
        
    }
}