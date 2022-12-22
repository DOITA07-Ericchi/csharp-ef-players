using System;
namespace Entity_Framework_Players {
	public class GeneraPartite {
		public static int GeneraPunteggio () {
			Random random = new Random ();
			int punteggio = random.Next (1, 10 + 1);
			return punteggio;
		}

		public static int[] GeneraNumero () {
			Random random = new Random ();
			int[] partiteGiocate = new int[2];
			partiteGiocate[0] = random.Next (1, 100 + 1);
			partiteGiocate[1] = random.Next (1, partiteGiocate[0] + 1);
			return partiteGiocate;
		}

		public GeneraPartite () {
		}
	}
}

