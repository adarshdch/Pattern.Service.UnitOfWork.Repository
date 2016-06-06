
using System.ComponentModel.DataAnnotations.Schema;
using Contract.Infrastructure;

namespace Implementation.EF6.Infrastructure
{
	public abstract class Entity : IObjectState
	{
		[NotMapped]
		public ObjectState ObjectState { get; set; }
	}
}
