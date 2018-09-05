namespace MovieApp.Controllers
{
	using System.Collections.Generic;
	using System.Web.Mvc;
	using MovieApp.Models;
	using MovieApp.ViewModels;

	public class MoviesController : Controller
	{
		private List<Customer> customers = new List<Customer>
			{
				new Customer { Name = "Customer1"},
				new Customer { Name = "Customer2"},
				new Customer { Name = "Customer3"}
			};

		private List<Movie> movies = new List<Movie>
			{
				new Movie { Id = 1, Name = "Shrek"},
				new Movie { Id = 2, Name = "Simbad"},
				new Movie { Id = 3, Name = "Waterfall"}
			};

		public ActionResult Random()
		{
			var movie = new Movie() { Name = "Shrek" };
			
			var viewModel = new RandomViewModel
			{
				Movie = movie,
				Customers = customers
			};

			return View(viewModel);
		}

		public ActionResult Index()
		{
			var modelView = new ViewAllMovies
			{
				Movies = movies
			};

			return View(modelView);
		}
	}
}