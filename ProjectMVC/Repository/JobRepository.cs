using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
    public class JobRepository : IJob
    {
        Context context;

        public string Id { get; set; }

        public JobRepository(Context _context)
        {

            Id = Guid.NewGuid().ToString();//unique
            context = _context;//new Context();
        }
        public List<Job> GetAll()//string includes=null)
        {
            return context.Jobs.ToList();
        }
        public Job GetById(int id)
        {
            return context.Jobs.FirstOrDefault(e => e.Id == id);
        }
        public void Insert(Job obj)
        {
            context.Add(obj);
        }
        public void Update(Job obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            Job cat = GetById(id);
            context.Remove(cat);
        }
        public List<Job> GetByCatID(int catID)
        {
            return context.Jobs.Where(e => e.CategoryId == catID).ToList();
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
