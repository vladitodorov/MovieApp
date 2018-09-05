namespace MovieApp.ViewModels
{
	using MovieApp.Models;
	using System.Collections.Generic;
	
	public class RandomViewModel
	{
		public Movie Movie { get; set; }

		public List<Customer> Customers { get; set; }
	}
}