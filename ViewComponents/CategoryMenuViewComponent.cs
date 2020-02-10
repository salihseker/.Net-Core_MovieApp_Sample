using Microsoft.AspNetCore.Mvc;
using NetCore_MovieApp.Data;

namespace NetCore_MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if(RouteData.Values["action"].ToString() == "Index")
                ViewBag.SelectedCategoryId = RouteData?.Values["id"];
                
            return View(CategoryRepository.Categorys);
        }
    }
}