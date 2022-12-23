using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Players {
	// Milestone 2
	[Table ("team")]
	[Index (nameof (TeamId), IsUnique = true)]
	public class Team {
		[Key]
		public int TeamId { get; set; }
		[Required]
		public string Nome { get; set; }
		public string Città { get; set; }
		public string Allenatore { get; set; }
		public string Colori { get; set; }

		public List<Player> Giocatori { get; set; }
	}
}

