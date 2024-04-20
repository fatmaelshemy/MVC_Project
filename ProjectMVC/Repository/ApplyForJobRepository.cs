using Microsoft.EntityFrameworkCore;
using ProjectMVC.Models;


namespace ProjectMVC.Repository
{
    public class ApplyForJobRepository : IApplyForJob
    {
        Context context;
        public ApplyForJobRepository(Context _context)
        {          
            context = _context;
        }
        public void Apply(ApplyForJob job)
        {
            job.DateTime = DateTime.Now;  
            context.ApplyForJobs.Add(job);
            context.SaveChanges();         
        }
        public void ApplySuccess()
        {
           
        }
    }
}
