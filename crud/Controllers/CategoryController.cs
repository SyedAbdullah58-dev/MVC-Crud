using crud.Data;
using crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext applicationDbContext;

        public CategoryController( ApplicationDbContext dbContext)
        {
            applicationDbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categoryList = applicationDbContext.categories;

            return View(categoryList);
        }
    }
}
