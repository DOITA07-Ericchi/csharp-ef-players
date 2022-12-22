using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Players {
	// Milestone 0
	[Table ("player")]
	[Index (nameof (id), IsUnique = true)]
	public class Player {
		[Key]
		public int id { get; set; }
		[Required]
		public string nome { get; set; }
		public string cognome { get; set; }
		public int punteggio { get; set; }
		public int nPartiteGiocate { get; set; }
		public int nPartiteVinte { get; set; }
	}
}

