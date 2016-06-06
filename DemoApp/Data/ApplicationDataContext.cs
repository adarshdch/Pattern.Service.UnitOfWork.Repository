using System.Data.Entity;
using DemoApp.Models;
using Implementation.EF6.DataContexts;

namespace DemoApp.Data
{

	public partial class ApplicationDataContext : DataContext
	{
		public ApplicationDataContext() : base("ExistingDbCodeFirstDemo")
		{
		}

		public ApplicationDataContext(string nameOrConnectionString)
			: base(nameOrConnectionString)
		{
		}

		public virtual DbSet<ExistingTable> ExistingTables { get; set; }
		public virtual DbSet<NewTable> NewTables { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
