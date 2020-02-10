using Microsoft.AspNetCore.Mvc;
using NetCore_MovieApp.Data;

namespace NetCore_MovieApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View(MovieRepository.Movies);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }
        
        
        
    }
}