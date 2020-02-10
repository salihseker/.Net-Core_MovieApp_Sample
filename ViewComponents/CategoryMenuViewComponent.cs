using Microsoft.AspNetCore.Mvc;
using NetCore_MovieApp.Data;

namespace NetCore_MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categorys);
        }
    }
}