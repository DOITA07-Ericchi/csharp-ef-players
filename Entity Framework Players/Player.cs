using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Players {
	// Milestone 0
	[Table ("player")]
	[Index (nameof (playerId), IsUnique = true)]
	public class Player {
		[Key]
		public int playerId { get; set; }
		[Required]
		public string nome { get; set; }
		public string cognome { get; set; }
		public int punteggio { get; set; }
		public int nPartiteGiocate { get; set; }
		public int nPartiteVinte { get; set; }

		// Milestone 2
		public int teamId { get; set; }
		public Team team { get; set; }
	}
}
