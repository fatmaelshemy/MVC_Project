namespace ProjectMVC.Models
{
	public class Campany
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }

		public List<Job> Jobs { get; set; }

	}
}