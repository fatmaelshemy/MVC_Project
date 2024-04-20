using ProjectMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.ViewModel
{
    public class JobWithCategoryNameVm
    {
        public int Id { get; set; }
        [MaxLength(25)]
        [MinLength(10)]
        public string Name { get; set; }
        [Required(ErrorMessage = "The position Is Required")]

        public string Position { get; set; }

        public string? Image { get; set; }
        public DateTime? DateTime { get; set; }

        [MaxLength(200)]
        [MinLength(50)]
        public string Description { get; set; }

        public string Type { get; set; } //part time or Full

        public String Location { get; set; }
        [Range(5000, 25000, ErrorMessage = "The Salary must be between 5000 and 25000.")]
        public Double Salary { get; set; }

        public int SelectedCategoryId { get; set; }
        public List<Category>? Categories { get; set; }


        public int? SelectedCompanyId { get; set; }
        public List<Campany>? Companies { get; set; }

    }
}
