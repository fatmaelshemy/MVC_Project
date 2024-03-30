using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using ProjectMVC.Repository;

namespace ProjectMVC.Controllers
{
    public class CategoryController : Controller
    {

        ICategory _CategoryRepository;
        IJob _JobRepository;

        public CategoryController(ICategory CategoryRepository, IJob JobRepository)
        {
            _CategoryRepository = CategoryRepository;
            _JobRepository = JobRepository;
        }

        //public IActionResult Index()
        //{

        //    List<Category> catListModel = _CategoryRepository.GetAll();
        //    return View("Index", catListModel);

        //}

        public IActionResult GetJobByCatID(int catID)
        {
            var categories = _JobRepository.GetByCatID(catID)
                .Select(e => new { e.Name, e.Id }).ToList();

            return Json(categories);

        }

        public IActionResult ShowCategoriesJob()
        {
            List<Category> categories = _CategoryRepository.GetAll();
            return View("ShowCategoriesJob", categories);
        }

        [HttpGet]
        public IActionResult New()
        {
            return View("NewCat");
        }

        [HttpPost]
        public IActionResult SaveNEw(Category cat)
        {
            if (cat.Name != null && cat.Description != null)
            {
                _CategoryRepository.Insert(cat);
                _CategoryRepository.Save();

                return RedirectToAction("Index");
            }
            return View("NewDept", cat);
        }

        public IActionResult Delete(int id)
        {
            return View("Delete", _CategoryRepository.GetById(id));
        }
    }
}
