using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Players {
	// Milestone 2
	[Table ("team")]
	[Index (nameof (teamId), IsUnique = true)]
	public class Team {
		[Key]
		public int teamId { get; set; }
		[Required]
		public string nome { get; set; }
		public string città { get; set; }
		public string allenatore { get; set; }
		public string colori { get; set; }

		public List<Player> giocatori { get; set; }
	}
}

