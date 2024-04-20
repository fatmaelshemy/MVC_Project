using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
	public interface IApplyForJob
	{
        public void Apply(ApplyForJob job);
        public void ApplySuccess();
       
    }
}
