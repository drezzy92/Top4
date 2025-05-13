namespace Top4;
using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Console.WriteLine("Willkommen zur Pokémon-Liga!");

		List<Pokemon> spielerTeam = TeamFactory.ErstelleSpielerteam();
		List<Trainer> gegner = TeamFactory.ErstelleGegner();

		foreach (var trainer in gegner)
		{
			Console.WriteLine($"\n=== {trainer.Name} fordert dich heraus! ===");
			bool gewonnen = KampfSystem.Kämpfe(spielerTeam, trainer.Team);

			if (!gewonnen)
			{
				Console.WriteLine($"Du wurdest von {trainer.Name} besiegt!");
				return;
			}

			Console.WriteLine($"Du hast {trainer.Name} besiegt!");
		}

		Console.WriteLine("Herzlichen Glückwunsch! Du hast die Pokémon-Liga gemeistert!");
	}
}
