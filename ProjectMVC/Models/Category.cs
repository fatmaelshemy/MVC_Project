
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(30)]
        [MinLength(10)]
        public string Name { get; set; }
        [MaxLength(200)]
        [MinLength(100)]
        public string Description { get; set; }

        public List<Job>? Jobs { get; set; }

    }
}
