using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjectMVC.Models;
using ProjectMVC.Repository;

namespace ProjectMVC.Controllers
{
    public class ApplyForJobController : Controller
    {
        IApplyForJob apply { get; set; }
 Apply
        public ApplyForJobController(IApplyForJob iApply )
        {
            apply= iApply;
        }
        [HttpPost]
        //[Authorize]
        public IActionResult Apply(ApplyForJob model)
        {
            // var model=new ApplyForJob();
            this.apply.Apply(model);
            return View("Apply");
        }

       

        public ApplyForJobController(IApplyForJob iApply)
        {
            apply = iApply;
        }
       // [HttpPost]
        //[Authorize]
        //public IActionResult Apply(ApplyForJob model)
        //{
        //    // var model=new ApplyForJob();
        //    //this.apply.Apply(model);
        //    //return View("Apply");
        //}


master
    }


}


