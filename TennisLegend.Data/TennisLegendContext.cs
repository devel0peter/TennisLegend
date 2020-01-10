using Microsoft.EntityFrameworkCore;
using TennisLegend.Data.Entities;

namespace TennisLegend.Data
{
	public class TennisLegendContext : DbContext
	{
		protected TennisLegendContext() : base()
		{
		}

		public TennisLegendContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Competition> Competitions { get; set; }
		public DbSet<Match> Matches { get; set; }
		public DbSet<Player> Players { get; set; }
		public DbSet<Team> Teams { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Ignore<Participant>();
			modelBuilder.Ignore<IdentifiedItem>();
		}
	}
}
