using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace TennisLegend.Data.Entities
{
	public class Match : IdentifiedItem
	{
		public Participant SideA { get; set; }
		public Participant SideB { get; set; }

		[Required]
		public Competition Competition { get; set; }

		public MatchType Type { get; set; }
		public string Score { get; set; }
		public DateTime Date { get; set; }
		public string Place { get; set; }

		public bool IsPlayed
		{
			get { return Score != null; }
		}
	}
}