using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Players {
	// Milestone 0
	[Table ("player")]
	[Index (nameof (PlayerId), IsUnique = true)]
	public class Player {
		[Key]
		public int PlayerId { get; set; }
		[Required]
		public string Nome { get; set; }
		public string Cognome { get; set; }
		public int Punteggio { get; set; }
		public int NPartiteGiocate { get; set; }
		public int NPartiteVinte { get; set; }

		// Milestone 2
		public int TeamId { get; set; }
		public Team Team { get; set; }
	}
}
