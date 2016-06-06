using System.Web.Mvc;
using Contract.DataContext;
using Contract.Repository;
using Contract.UnitOfWork;
using DemoApp.Data;
using DemoApp.Models;
using Implementation.EF6.DataContexts;
using Implementation.EF6.Repositories;
using Implementation.EF6.UnitOfWorks;

namespace DemoApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly IDataContextAsync _applicationDataContextAsync = null;
		private readonly IUnitOfWorkAsync _unitOfWork = null;
		private readonly IRepository<ExistingTable> _existingTableRepository = null;

		public HomeController()
		{
			_applicationDataContextAsync = new ApplicationDataContext("ExistingDbCodeFirstDemo");
			_unitOfWork = new UnitOfWork(_applicationDataContextAsync);
			_existingTableRepository = new Repository<ExistingTable>(_applicationDataContextAsync, _unitOfWork);

		}

		public ActionResult Index()
		{
			var data = _existingTableRepository.Find(10);

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}