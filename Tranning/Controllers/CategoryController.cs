using Microsoft.AspNetCore.Mvc;
using Tranning.DataDBContext;
using Tranning.Models;

namespace Tranning.Controllers
{
    public class CategoryController : Controller
    {
        private readonly TranningDBContext _dbContext;
        public CategoryController(TranningDBContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CategoryModel categoryModel = new CategoryModel();
            categoryModel.CategoryDetailLists = new List<CategoryDetail>();
            var data = _dbContext.Categories.ToList();
            foreach (var item in data)
            {
                categoryModel.CategoryDetailLists.Add(new CategoryDetail
                {
                    id = item.id,
                    name = item.name,
                    description = item.description,
                    icon = item.icon,
                    status = item.status,
                    created_at = item.created_at,
                    updated_at = item.updated_at
                });
            }

            return View(categoryModel);
        }
    }
}
