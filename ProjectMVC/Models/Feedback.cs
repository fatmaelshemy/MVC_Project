using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
	public class Feedback
	{
		public int Id { get; set; }
		public string Message { get; set; }

		[ForeignKey("User")]
		public string UserId { get; set; }
		public ApplicationUser User { get; set; }
	}
}
