using ProjectMVC.Models;

namespace ProjectMVC.Repository
{
    public interface ICategory
    {
        public List<Category> GetAll();//string includes=null)


        public Category GetById(int id);

        public void Insert(Category obj);

        public void Update(Category obj);

        public void Delete(int id);

        public void Save();

    }
}
