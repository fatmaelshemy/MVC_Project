using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
    public class CategoryRepository : ICategory
    {
        Context context;

        public string Id { get; set; }

        public CategoryRepository(Context _context)
        {

            Id = Guid.NewGuid().ToString();
            context = _context;
        }
        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }
        public Category GetById(int id)
        {
            return context.Categories.FirstOrDefault(e => e.Id == id);
        }
        public void Insert(Category obj)
        {
            context.Add(obj);
        }
        public void Update(Category obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            Category cat = GetById(id);
            context.Remove(cat);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
