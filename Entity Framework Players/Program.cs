using Entity_Framework_Players;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using (PlayersContext pcDb = new PlayersContext ()) {
	// Milestone 1.1
	int punteggio = GeneraPartite.GeneraPunteggio ();
	int [] partiteGiocate = GeneraPartite.GeneraNumero ();

	Player marcofiero = new Player { Nome = "Marcu", Cognome = "Fiero", NPartiteGiocate = GeneraPartite.GeneraNumero () [0], NPartiteVinte = GeneraPartite.GeneraNumero () [1] };

	pcDb.Add (marcofiero);

	// Milestone 1.2
	Console.WriteLine ("Inserito: " + marcofiero.Nome + " " + marcofiero.Cognome);

	// Milestone 1.3
	marcofiero.Nome = "Marco";
	marcofiero.Cognome = "Silva";

	// Milestone 1.4
	pcDb.Remove (marcofiero);

	// Milestone 3
	Player Wolfey = new Player { Nome = "Wolfe", Cognome = "Glick", NPartiteGiocate = GeneraPartite.GeneraNumero () [0], NPartiteVinte = GeneraPartite.GeneraNumero () [1] };
	Player Cybertron = new Player { Nome = "Aaron", Cognome = "Zheng", NPartiteGiocate = GeneraPartite.GeneraNumero () [0], NPartiteVinte = GeneraPartite.GeneraNumero () [1] };
	Player Alexis = new Player { Nome = "Francesco", Cognome = "Pardini", NPartiteGiocate = GeneraPartite.GeneraNumero () [0], NPartiteVinte = GeneraPartite.GeneraNumero () [1] };
	Team VGC = new Team { Nome = "VGC", Città = "Altopiano Blu", Allenatore = "Alisma", Colori = "RossoBianco", Giocatori = new List<Player>() };
	pcDb.Add(VGC);
	VGC.Giocatori.Add(Wolfey);
	VGC.Giocatori.Add(Cybertron);
	VGC.Giocatori.Add(Alexis);
	pcDb.SaveChanges();
}
