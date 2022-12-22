using System;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Players {
	public class PlayersContext : DbContext {
		public DbSet<Player> Players { get; set; }
		public DbSet<Team> Teams { get; set; }

		protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer ("Data Source=localhost;Database=Players;User Id=SA;Password=nekonekonyaa9021;TrustServerCertificate=True");
		}
	}
}

