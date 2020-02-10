using System.Collections.Generic;
using System.Linq;
using NetCore_MovieApp.Models;

namespace NetCore_MovieApp.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _Categorys = null;
        static CategoryRepository()
        {
             _Categorys = new List<Category>()
             {
                 new Category{Id= 1 , Name = "Fantastik" },
                 new Category{Id= 2 , Name = "Aksiyon" },
                 new Category{Id= 3 , Name = "Bilim Kurgu" },
                 new Category{Id= 4 , Name = "Dram" }
            };
        }

        public static List<Category> Categorys
        {
            get
            {
                return _Categorys;
            }
        }

        public static void AddCategory(Category enitiy)
        {
            _Categorys.Add(enitiy);
        }

        public static Category GetById(int id)
        {
            return _Categorys.FirstOrDefault(x => x.Id == id);
        }
    }
}