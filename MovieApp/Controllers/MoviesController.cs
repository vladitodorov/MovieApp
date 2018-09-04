namespace MovieApp.Controllers
{
	using System.Web.Mvc;
	using MovieApp.Models;

	public class MoviesController : Controller
	{
		public ActionResult Random()
		{
			var movie = new Movie() { Name = "Shrek" };

			return View(movie);
		}

		public ActionResult Edit(int id)
		{
			return Content("id=" + id);
		}
	}
}