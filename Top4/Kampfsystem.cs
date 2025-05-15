using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Threading;

public static class KampfSystem
{
	public static bool Kämpfe(List<Pokemon> spieler, List<Pokemon> gegner)
	{
		Random rand = new Random();

		// 1x zu Beginn: Start-Pokémon wählen
		WriteLineMitPause("Wähle dein Start-Pokémon:");
		for (int x = 0; x < spieler.Count; x++)
			DirektWriteLine($"{x + 1}. {spieler[x].Name} (KP: {spieler[x].AktuelleKP})");

		int startIndex = -1;
		while (startIndex < 1 || startIndex > spieler.Count)
		{
			Console.Write("Auswahl (1-" + spieler.Count + "): ");
			int.TryParse(Console.ReadLine(), out startIndex);
		}

		// Gewähltes Pokémon an erste Position verschieben
		if (startIndex - 1 != 0)
		{
			var temp = spieler[startIndex - 1];
			spieler[startIndex - 1] = spieler[0];
			spieler[0] = temp;
		}

		int i = 0, j = 0;

		while (i < spieler.Count && j < gegner.Count)
		{
			var sp = spieler[i];
			var gp = gegner[j];

			WriteLineMitPause($"\nDu setzt {sp.Name} (KP: {sp.AktuelleKP}) ein. Gegner: {gp.Name} (KP: {gp.AktuelleKP})");

			while (!sp.IstBesiegt() && !gp.IstBesiegt())
			{
				// Attacke wählen
				Console.WriteLine("\nWähle eine Attacke:");
				for (int a = 0; a < sp.Attacken.Count; a++)
					DirektWriteLine($"{a + 1}. {sp.Attacken[a].Name} ({sp.Attacken[a].Typ})");

				int auswahl = -1;
				while (auswahl < 1 || auswahl > sp.Attacken.Count)
				{
					Console.Write("Auswahl (1-" + sp.Attacken.Count + "): ");
					int.TryParse(Console.ReadLine(), out auswahl);
				}

				var atk = sp.Attacken[auswahl - 1];
				double effekt = TypenBerechnung.Berechne(atk.Typ, gp.Typ1, gp.Typ2);
				int schaden = Math.Max(1, (int)(atk.Schaden * effekt));
				gp.AktuelleKP -= schaden;
				WriteLineMitPause($"{sp.Name} setzt {atk.Name} ein! Schaden: {schaden}");

				ZeigeEffektivitätsText(effekt);

				if (gp.IstBesiegt()) break;

				// Gegner greift an
				var gegAtk = gp.Attacken[rand.Next(gp.Attacken.Count)];
				effekt = TypenBerechnung.Berechne(gegAtk.Typ, sp.Typ1, sp.Typ2);
				schaden = Math.Max(1, (int)(gegAtk.Schaden * effekt));
				sp.AktuelleKP -= schaden;
				WriteLineMitPause($"{gp.Name} kontert mit {gegAtk.Name}! Schaden: {schaden}");

				ZeigeEffektivitätsText(effekt);
			}

			if (sp.IstBesiegt())
			{
				WriteLineMitPause($"{sp.Name} wurde besiegt.");
				i++;
				while (i < spieler.Count && spieler[i].IstBesiegt()) i++;
			}
			else
			{
				WriteLineMitPause($"{gp.Name} wurde besiegt.");
				j++;

				// Nach besiegtem Gegner: Wechseloption
				if (j < gegner.Count) // Nur wenn noch Gegner übrig
				{
					WriteLineMitPause("Möchtest du dein Pokémon wechseln? (j/n)");
					string antwort = Console.ReadLine()?.ToLower();
					if (antwort == "j")
					{
						// Nur kampffähige anzeigen
						for (int x = 0; x < spieler.Count; x++)
						{
							if (!spieler[x].IstBesiegt() && x != i)
								DirektWriteLine($"{x + 1}. {spieler[x].Name} (KP: {spieler[x].AktuelleKP})");
						}

						int wechsel = -1;
						while (wechsel < 1 || wechsel > spieler.Count || spieler[wechsel - 1].IstBesiegt() || wechsel - 1 == i)
						{
							Console.Write("Auswahl: ");
							int.TryParse(Console.ReadLine(), out wechsel);
						}

						// Pokémon tauschen
						var tmp = spieler[i];
						spieler[i] = spieler[wechsel - 1];
						spieler[wechsel - 1] = tmp;
						WriteLineMitPause($"Du hast {spieler[i].Name} in den Kampf geschickt.");
					}
				}
			}
		}

		return j >= gegner.Count;
	}

	private static void ZeigeEffektivitätsText(double effekt)
	{
		if (effekt > 1.0)
			WriteLineMitPause("Es war sehr effektiv!");
		else if (effekt < 1.0 && effekt > 0.0)
			WriteLineMitPause("Es war nicht sehr effektiv.");
		else if (effekt == 0.0)
			WriteLineMitPause("Es hatte keine Wirkung!");
	}

	private static void WriteLineMitPause(string text)
	{
		Console.WriteLine(text);
		Thread.Sleep(1000); // 1 Sekunde Verzögerung
	}

	private static void DirektWriteLine(string text)
	{
		Console.WriteLine(text); // Sofortige Ausgabe
	}
}
