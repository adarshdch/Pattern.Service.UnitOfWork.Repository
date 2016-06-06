using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Implementation.EF6.Infrastructure;

namespace DemoApp.Models
{

	[Table("ExistingTable")]
	public partial class ExistingTable : Entity
	{
		public ExistingTable()
		{

		}

		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id { get; set; }

		[StringLength(50)]
		public string Data { get; set; }
	}
}
