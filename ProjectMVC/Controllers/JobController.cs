using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ProjectMVC.Hubs;
using ProjectMVC.Models;
using ProjectMVC.Repository;
using ProjectMVC.ViewModel;
namespace ProjectMVC.Controllers
{
    public class JobController : Controller
    {
        ICategory _CategoryRepository;
        IJob _JobRepository;
        IApplyForJob _ApplyForJob;
        ICampany _CompanyRepository;
        IHubContext<jobHub> hubContext;

        public JobController
                (ICategory CategoryRepository, IJob JobRepository, ICampany CompanyRepository, IHubContext<jobHub> _hubContext)
        {
            _CategoryRepository = CategoryRepository;
            _JobRepository = JobRepository;
            _CompanyRepository = CompanyRepository;
            hubContext = _hubContext;

        }


        //public IActionResult Index()
        //{

        //    List<Job> JobListModel = _JobRepository.GetAll();
        //    return View("Index", JobListModel);

        //}

        [HttpGet]
        public IActionResult FullTimeJobIndex()
        {
            List<Job> JobListModel2 = _JobRepository.GetFullTimeJob();
            return View("FullTimeJobIndex", JobListModel2);
        }
        [HttpGet]
        public IActionResult PartTimeJobIndex()
        {
            List<Job> JobListModel1 = _JobRepository.GetPartTimeJob();
            return View("PartTimeJobIndex", JobListModel1);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult New()
        {
            var viewModel = new JobWithCategoryNameVm
            {
                Categories = _CategoryRepository.GetAll(),
                Companies = _CompanyRepository.GetAll()
            };
            return View("NewJob", viewModel);
        }

        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public IActionResult SaveNew(JobWithCategoryNameVm jobview)
        {
            if ((ModelState.IsValid == true))
            {
                Job jobmodel = new Job
                {
                    Name = jobview.Name,
                    Description = jobview.Description,
                    Salary = jobview.Salary,
                    Position = jobview.Position,
                    DateTime = jobview.DateTime,
                    CategoryId = jobview.SelectedCategoryId,
                    Type = jobview.Type,
                    Location = jobview.Location,
                    CompanyId = jobview.SelectedCompanyId

                };
                _JobRepository.Insert(jobmodel);
                _JobRepository.Save();

                return RedirectToAction("FullTimeJobIndex");
            }
            return View("NewJob", jobview);
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {

            var jobToDelete = _JobRepository.GetById(id);
            if (jobToDelete == null)
            {
                return NotFound(); // Or handle not found case as needed
            }
            _JobRepository.Delete(id);

            return RedirectToAction("FullTimeJobIndex");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            Job jobModel = _JobRepository.GetById(id);
            if (jobModel == null)
                return NotFound("job Not Found");
            JobWithCategoryNameVm jobVM = new JobWithCategoryNameVm();
            jobVM.Name = jobModel.Name;
            jobVM.Position = jobModel.Position;
            jobVM.SelectedCategoryId = jobModel.CategoryId;
            jobVM.Salary = jobModel.Salary;
            jobVM.Location = jobModel.Location;
            jobVM.Type = jobModel.Type;
            jobVM.Description = jobModel.Description;
            jobVM.Categories = _CategoryRepository.GetAll();
            jobVM.Companies = _CompanyRepository.GetAll();

            return View("Edit", jobVM);
        }
        [HttpPost]
        public IActionResult SaveEdit(JobWithCategoryNameVm jobview)//Vm
        {
            if (jobview.Name != null && jobview.Description != null)
            {
                Job jobmodel = new Job
                {
                    Name = jobview.Name,
                    Description = jobview.Description,
                    Salary = jobview.Salary,
                    Position = jobview.Position,
                    DateTime = jobview.DateTime,
                    CategoryId = jobview.SelectedCategoryId,
                    Type = jobview.Type,
                    Location = jobview.Location
                    //CompanyId =jobview.SelectedCompanyId

                };
                _JobRepository.Update(jobmodel);
                _JobRepository.Save();

                return RedirectToAction("FullTimeJobIndex");
            }
            return View("Edit", jobview);
        }
        public IActionResult Details(int id)
        {
            Job jobModel = _JobRepository.GetById(id);
            return View("Details", jobModel);
        }

    }
}
