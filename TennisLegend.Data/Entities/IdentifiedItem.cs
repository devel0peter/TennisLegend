using System;

namespace TennisLegend.Data.Entities
{
	public class IdentifiedItem
	{
		public int Id { get; set; }
		public DateTime CreatedDateTimeUtc { get; set; }
		public DateTime? LastModifiedDateTimeUtc { get; set; }
	}
}
