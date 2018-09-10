namespace MovieApp.Controllers
{
	using MovieApp.Models;
	using MovieApp.ViewModels;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web.Mvc;

	public class CustomersController : Controller
    {
		private ApplicationDbContext _context;

		public CustomersController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		//private List<Customer> customers = new List<Customer>
		//	{
		//		new Customer {Id = 1, Name = "John Smith"},
		//		new Customer {Id = 2, Name = "Marry Magdalena"}
		//	};

		// GET: Customers
		public ActionResult Index()
        {
			var customers = _context.Customers.ToList();

			var model = new ViewAllCustomers
			{
				Customers = customers
			};
			 
			return View(model);
        }

		public ActionResult Details(int id)
		{
			var selectedCustomer = _context.Customers.Where(x => x.Id == id).FirstOrDefault();

			return View(selectedCustomer);
		}
    }
}