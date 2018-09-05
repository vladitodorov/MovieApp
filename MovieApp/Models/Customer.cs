namespace MovieApp.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Customer
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		public bool IsSubscribedToNewsLetter { get; set; }

		public byte MembershipId { get; set; }

		public MembershipType MembershipType { get; set; }
	}
}