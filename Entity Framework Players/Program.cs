using Entity_Framework_Players;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

Console.WriteLine ("MAIN!!!!!!");


using (PlayersContext pcDb = new PlayersContext ()) {
	// Milestone 1.1
	int punteggio = GeneraPartite.GeneraPunteggio ();
	int [] partiteGiocate = GeneraPartite.GeneraNumero ();

	Player marcofiero = new Player { nome = "Marcu", cognome = "Fiero", nPartiteGiocate = GeneraPartite.GeneraNumero () [0], nPartiteVinte = GeneraPartite.GeneraNumero () [1] };

	pcDb.Add (marcofiero);

	// Milestone 1.2
	Console.WriteLine ("Inserito: " + marcofiero.nome + " " + marcofiero.cognome);

	// Milestone 1.3
	marcofiero.nome = "Marco";
	marcofiero.cognome = "Silva";

	// Milestone 1.4
	pcDb.Remove (marcofiero);

	// Milestone 3
	Player Wolfey = new Player { nome = "Wolfe", cognome = "Glick", nPartiteGiocate = GeneraPartite.GeneraNumero () [0], nPartiteVinte = GeneraPartite.GeneraNumero () [1] };
	Player Cybertron = new Player { nome = "Aaron", cognome = "Zheng", nPartiteGiocate = GeneraPartite.GeneraNumero () [0], nPartiteVinte = GeneraPartite.GeneraNumero () [1] };
	Player Alexis = new Player { nome = "Francesco", cognome = "Pardini", nPartiteGiocate = GeneraPartite.GeneraNumero () [0], nPartiteVinte = GeneraPartite.GeneraNumero () [1] };
	Team VGC = new Team { nome = "VGC", città = "Altopiano Blu", allenatore = "Alisma", colori = "RossoBianco"};
}
