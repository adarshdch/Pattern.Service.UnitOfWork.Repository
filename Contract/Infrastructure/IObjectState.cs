using System.ComponentModel.DataAnnotations.Schema;

namespace Contract.Infrastructure
{
	public interface IObjectState
	{
		[NotMapped]
		ObjectState ObjectState { get; set; }
	}
}
