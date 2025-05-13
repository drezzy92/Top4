using System.Collections.Generic;

public static class TeamFactory
{
	public static List<Pokemon> ErstelleSpielerteam()
	{
		return new List<Pokemon>
		{
			new Pokemon("Glurak", 120, Typ.Feuer, Typ.Flug, new()
			{
				new Attacke("Flammenwurf", Typ.Feuer, 90),
				new Attacke("Luftschnitt", Typ.Flug, 75),
				new Attacke("Drachenklau", Typ.Drache, 80),
				new Attacke("Schlagbohrer", Typ.Normal, 80)
			}),
			new Pokemon("Turtok", 130, Typ.Wasser, null, new()
			{
				new Attacke("Hydropumpe", Typ.Wasser, 110),
				new Attacke("Eisstrahl", Typ.Eis, 90),
				new Attacke("Kopfnuss", Typ.Normal, 70),
				new Attacke("Turbodreher", Typ.Normal, 50)
			}),
			new Pokemon("Bisaflor", 125, Typ.Pflanze, Typ.Gift, new()
			{
				new Attacke("Solarstrahl", Typ.Pflanze, 120),
				new Attacke("Matschbombe", Typ.Gift, 90),
				new Attacke("Tackle", Typ.Normal, 40),
				new Attacke("Egelsamen", Typ.Pflanze, 0)
			}),
			new Pokemon("Pikachu", 100, Typ.Elektro, null, new()
			{
				new Attacke("Donnerblitz", Typ.Elektro, 90),
				new Attacke("Ruckzuckhieb", Typ.Normal, 40),
				new Attacke("Eisenschweif", Typ.Stahl, 100),
				new Attacke("Volt Tackle", Typ.Elektro, 120)
			}),
			new Pokemon("Dragoran", 150, Typ.Drache, Typ.Flug, new()
			{
				new Attacke("Hyperstrahl", Typ.Normal, 150),
				new Attacke("Drachenpuls", Typ.Drache, 85),
				new Attacke("Feuersturm", Typ.Feuer, 110),
				new Attacke("Fliegen", Typ.Flug, 90)
			}),
			new Pokemon("Psiana", 110, Typ.Psycho, null, new()
			{
				new Attacke("Psychokinese", Typ.Psycho, 90),
				new Attacke("Spukball", Typ.Geist, 80),
				new Attacke("Kraftreserve", Typ.Normal, 60),
				new Attacke("Lichtschild", Typ.Psycho, 0)
			})
		};
	}
	public static List<Trainer> ErstelleGegner()
	{
		return new List<Trainer>
		{
            // Trainer 1 – Willi (Elektro)
            new Trainer("Willi", new List<Pokemon>
			{
				new Pokemon("Magneton", 100, Typ.Elektro, Typ.Stahl, new()
				{
					new Attacke("Donnerblitz", Typ.Elektro, 90),
					new Attacke("Lichtkanone", Typ.Stahl, 80),
					new Attacke("Donnerschock", Typ.Elektro, 40),
					new Attacke("Superschall", Typ.Normal, 0)
				}),
				new Pokemon("Raichu", 110, Typ.Elektro, null, new()
				{
					new Attacke("Donner", Typ.Elektro, 110),
					new Attacke("Voltwechsel", Typ.Elektro, 70),
					new Attacke("Ruckzuckhieb", Typ.Normal, 40),
					new Attacke("Eisenschweif", Typ.Stahl, 100)
				}),
				new Pokemon("Elevoltek", 120, Typ.Elektro, null, new()
				{
					new Attacke("Donnerblitz", Typ.Elektro, 90),
					new Attacke("Kreuzhieb", Typ.Kampf, 100),
					new Attacke("Erdbeben", Typ.Boden, 100),
					new Attacke("Feuerschlag", Typ.Feuer, 75)
				}),
				new Pokemon("Ampharos", 130, Typ.Elektro, null, new()
				{
					new Attacke("Donner", Typ.Elektro, 110),
					new Attacke("Ladestrahl", Typ.Elektro, 50),
					new Attacke("Power-Punch", Typ.Kampf, 75),
					new Attacke("Signalstrahl", Typ.Käfer, 75)
				}),
				new Pokemon("Voltobal", 80, Typ.Elektro, null, new()
				{
					new Attacke("Explosion", Typ.Normal, 250),
					new Attacke("Ladevorgang", Typ.Elektro, 0),
					new Attacke("Donnerschock", Typ.Elektro, 40),
					new Attacke("Rollout", Typ.Gestein, 30)
				}),
				new Pokemon("Lanturn", 120, Typ.Wasser, Typ.Elektro, new()
				{
					new Attacke("Surfer", Typ.Wasser, 90),
					new Attacke("Donnerblitz", Typ.Elektro, 90),
					new Attacke("Konfusstrahl", Typ.Psycho, 0),
					new Attacke("Eisstrahl", Typ.Eis, 90)
				})
			}),
