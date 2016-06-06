using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using DemoApp.Data;
using DemoApp.Models;
using Implementation.EF6.UnitOfWorks;

namespace DemoApp.Controllers
{
	public class ExistingTablesController : Controller
	{
		private ApplicationDataContext db = new ApplicationDataContext();

		// GET: ExistingTables
		public ActionResult Index()
		{
			using (var context = new ApplicationDataContext())
			{
				using (var unitOfWork = new UnitOfWork(context))
				{
					var data = unitOfWork.Repository<ExistingTable>().Query().Select();
					return View(data.ToList());
				}
			}

			return View();
		}

		// GET: ExistingTables/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ExistingTable existingTable = db.ExistingTables.Find(id);
			if (existingTable == null)
			{
				return HttpNotFound();
			}
			return View(existingTable);
		}

		// GET: ExistingTables/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: ExistingTables/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Data")] ExistingTable existingTable)
		{
			if (ModelState.IsValid)
			{
				db.ExistingTables.Add(existingTable);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(existingTable);
		}

		// GET: ExistingTables/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ExistingTable existingTable = db.ExistingTables.Find(id);
			if (existingTable == null)
			{
				return HttpNotFound();
			}
			return View(existingTable);
		}

		// POST: ExistingTables/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Data")] ExistingTable existingTable)
		{
			if (ModelState.IsValid)
			{
				db.Entry(existingTable).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(existingTable);
		}

		// GET: ExistingTables/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			ExistingTable existingTable = db.ExistingTables.Find(id);
			if (existingTable == null)
			{
				return HttpNotFound();
			}
			return View(existingTable);
		}

		// POST: ExistingTables/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			ExistingTable existingTable = db.ExistingTables.Find(id);
			db.ExistingTables.Remove(existingTable);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
