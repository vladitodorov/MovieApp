namespace MovieApp.Controllers
{
	using MovieApp.Models;
	using MovieApp.ViewModels;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web.Mvc;

	public class CustomersController : Controller
    {
		private List<Customer> customers = new List<Customer>
			{
				new Customer {Id = 1, Name = "John Smith"},
				new Customer {Id = 2, Name = "Marry Magdalena"}
			};

		// GET: Customers
		public ActionResult Index()
        {
					var model = new ViewAllCustomers
			{
				Customers = customers
			};

			return View(model);
        }

		public ActionResult Details(int id)
		{
			var selectedCustomer = customers.Where(x => x.Id == id).FirstOrDefault();

			return View(selectedCustomer);
		}
    }
}