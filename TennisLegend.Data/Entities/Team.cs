namespace TennisLegend.Data.Entities
{
	public class Team : Participant
	{
		public Player PlayerOne { get; set; }
		public Player PlayerTwo { get; set; }
	}
}
