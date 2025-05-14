using System;
using System.Collections.Generic;

public static class KampfSystem
{
	public static bool Kämpfe(List<Pokemon> spielerTeam, List<Pokemon> gegnerTeam)
	{
		int spielerIndex = 0;
		int gegnerIndex = 0;

		while (spielerIndex < spielerTeam.Count && gegnerIndex < gegnerTeam.Count)
		{
			Pokemon spielerPokemon = spielerTeam[spielerIndex];
			Pokemon gegnerPokemon = gegnerTeam[gegnerIndex];

			Console.WriteLine($"\n{spielerPokemon.Name} VS {gegnerPokemon.Name}");

			while (!spielerPokemon.IstBesiegt() && !gegnerPokemon.IstBesiegt())
			{
				// Spieler greift an  
				gegnerPokemon.KP -= Convert.ToInt32(spielerPokemon.Angriff);
				Console.WriteLine($"{spielerPokemon.Name} greift an! {gegnerPokemon.Name} hat noch {Math.Max(0, gegnerPokemon.KP)} KP.");

				if (gegnerPokemon.IstBesiegt())
				{
					Console.WriteLine($"{gegnerPokemon.Name} wurde besiegt!");
					gegnerIndex++;
					break;
				}

				// Gegner greift an  
				spielerPokemon.KP -= Convert.ToInt32(gegnerPokemon.Angriff);
				Console.WriteLine($"{gegnerPokemon.Name} greift an! {spielerPokemon.Name} hat noch {Math.Max(0, spielerPokemon.KP)} KP.");

				if (spielerPokemon.IstBesiegt())
				{
					Console.WriteLine($"{spielerPokemon.Name} wurde besiegt!");
					spielerIndex++;
					break;
				}
			}
		}

		return spielerIndex < spielerTeam.Count;
	}
}
