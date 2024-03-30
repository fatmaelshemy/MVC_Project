using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Repository;

namespace ProjectMVC.Controllers
{
    public class JobController : Controller
    {
        ICategory _CategoryRepository;
        IJob _JobRepository;

        public JobController
                (ICategory CategoryRepository, IJob JobRepository)
        {
            _CategoryRepository = CategoryRepository;
            _JobRepository = JobRepository;
        }


        public IActionResult Index()
        {
            return View("Index", _JobRepository.GetAll());
        }



    }
}
