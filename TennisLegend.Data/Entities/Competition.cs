using System;
using System.Collections.Generic;
using TennisLegend.Data.Enums;

namespace TennisLegend.Data.Entities
{
	public class Competition : IdentifiedItem
	{
		public string Name { get; set; }
		public CompetitionType Type { get; set; }
		public List<Participant> Participants { get; set; }
		public List<Match> Matches { get; set; }
		public string Rules { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public bool IsStarted
		{
			get { return StartDate >= DateTime.Today; }
		}
	}
}
