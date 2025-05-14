using System.Collections.Generic;

public static class TeamFactory
{
	public static List<Pokemon> ErstelleSpielerteam()
	{
		return new List<Pokemon>
		{
			new Pokemon("Glurak", 190, Typ.Feuer, Typ.Drache, new()
			{
				new Attacke("Feuersturm", Typ.Feuer, 130),
				new Attacke("Luftschnitt", Typ.Flug, 75),
				new Attacke("Draco-Meteor", Typ.Drache, 130),
				new Attacke("Solarstrahl", Typ.Pflanze, 120)
			}),
			new Pokemon("Turtok", 200, Typ.Wasser, Typ.Wasser, new()
			{
				new Attacke("Hydropumpe", Typ.Wasser, 110),
				new Attacke("Eisstrahl", Typ.Eis, 90),
				new Attacke("Kopfnuss", Typ.Normal, 70),
				new Attacke("Lichtkanone", Typ.Stahl, 80)
			}),
			new Pokemon("Bisaflor", 205, Typ.Pflanze, Typ.Gift, new()
			{
				new Attacke("Solarstrahl", Typ.Pflanze, 120),
				new Attacke("Matschbombe", Typ.Gift, 90),
				new Attacke("Bodyslam", Typ.Normal, 90),
				new Attacke("Erdbeben", Typ.Boden, 100)
			}),
			new Pokemon("Elevoltek", 160, Typ.Elektro, Typ.Elektro, new()
			{
				new Attacke("Donnerblitz", Typ.Elektro, 90),
				new Attacke("Feuerschlag", Typ.Feuer, 70),
				new Attacke("Eisenschweif", Typ.Stahl, 100),
				new Attacke("Volt Tackle", Typ.Elektro, 120)
			}),
			new Pokemon("Dragoran", 220, Typ.Drache, Typ.Flug, new()
			{
				new Attacke("Hyperstrahl", Typ.Normal, 150),
				new Attacke("Drachenpuls", Typ.Drache, 85),
				new Attacke("Feuersturm", Typ.Feuer, 130),
				new Attacke("Fliegen", Typ.Flug, 90)
			}),
			new Pokemon("Mewtwo", 260, Typ.Psycho, Typ.Psycho, new()
			{
				new Attacke("Psychokinese", Typ.Psycho, 90),
				new Attacke("Spukball", Typ.Geist, 80),
				new Attacke("Eisstrahl", Typ.Eis, 90),
				new Attacke("Aurasphäre", Typ.Kampf, 80)
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
				new Pokemon("Raichu", 110, Typ.Elektro, Typ.Elektro, new()
				{
					new Attacke("Donner", Typ.Elektro, 110),
					new Attacke("Voltwechsel", Typ.Elektro, 70),
					new Attacke("Ruckzuckhieb", Typ.Normal, 40),
					new Attacke("Eisenschweif", Typ.Stahl, 100)
				}),
				new Pokemon("Elevoltek", 120, Typ.Elektro, Typ.Elektro, new()
				{
					new Attacke("Donnerblitz", Typ.Elektro, 90),
					new Attacke("Kreuzhieb", Typ.Kampf, 100),
					new Attacke("Erdbeben", Typ.Boden, 100),
					new Attacke("Feuerschlag", Typ.Feuer, 75)
				}),
				new Pokemon("Ampharos", 130, Typ.Elektro, Typ.Elektro, new()
				{
					new Attacke("Donner", Typ.Elektro, 110),
					new Attacke("Ladestrahl", Typ.Elektro, 50),
					new Attacke("Power-Punch", Typ.Kampf, 75),
					new Attacke("Signalstrahl", Typ.Käfer, 75)
				}),
				new Pokemon("Voltobal", 80, Typ.Elektro, Typ.Elektro, new()
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

            // Trainer 2 – Koga (Gift)
            new Trainer("Koga", new List<Pokemon>
			{
				new Pokemon("Giflor", 120, Typ.Pflanze, Typ.Gift, new()
				{
					new Attacke("Matschbombe", Typ.Gift, 90),
					new Attacke("Gigasauger", Typ.Pflanze, 75),
					new Attacke("Schlafpuder", Typ.Pflanze, 0),
					new Attacke("Solarstrahl", Typ.Pflanze, 120)
				}),
				new Pokemon("Iksbat", 110, Typ.Gift, Typ.Flug, new()
				{
					new Attacke("Flügelschlag", Typ.Flug, 60),
					new Attacke("Giftzahn", Typ.Gift, 80),
					new Attacke("Konfustrahl", Typ.Psycho, 0),
					new Attacke("Schattenstoß", Typ.Geist, 40)
				}),
				new Pokemon("Sleimok", 130, Typ.Gift, Typ.Gift, new()
				{
					new Attacke("Matschbombe", Typ.Gift, 90),
					new Attacke("Erdbeben", Typ.Boden, 100),
					new Attacke("Bodycheck", Typ.Normal, 85),
					new Attacke("Toxin", Typ.Gift, 0)
				}),
				new Pokemon("Panzaeron", 140, Typ.Stahl, Typ.Flug, new()
				{
					new Attacke("Metallklaue", Typ.Stahl, 50),
					new Attacke("Sturzflug", Typ.Flug, 120),
					new Attacke("Sandwirbel", Typ.Boden, 0),
					new Attacke("Bohrschnabel", Typ.Flug, 80)
				}),
				new Pokemon("Forstellka", 120, Typ.Käfer, Typ.Stahl, new()
				{
					new Attacke("Gyroball", Typ.Stahl, 80),
					new Attacke("Stachler", Typ.Boden, 0),
					new Attacke("Explosion", Typ.Normal, 250),
					new Attacke("Käferbiss", Typ.Käfer, 60)
				}),
				new Pokemon("Ariados", 100, Typ.Käfer, Typ.Gift, new()
				{
					new Attacke("Käfergebrumm", Typ.Käfer, 90),
					new Attacke("Gifthieb", Typ.Gift, 80),
					new Attacke("Fadenschuss", Typ.Käfer, 0),
					new Attacke("Schmarotzer", Typ.Unlicht, 95)
				})
			}),

            // Trainer 3 – Bruno (Kampf)
            new Trainer("Bruno", new List<Pokemon>
			{
				new Pokemon("Hariyama", 130, Typ.Kampf, Typ.Kampf, new()
				{
					new Attacke("Wuchtschlag", Typ.Kampf, 100),
					new Attacke("Schlagbohrer", Typ.Normal, 80),
					new Attacke("Steinhagel", Typ.Gestein, 75),
					new Attacke("Power-Punch", Typ.Kampf, 75)
				}),
				new Pokemon("Machomei", 140, Typ.Kampf, Typ.Kampf, new()
				{
					new Attacke("Kreuzhieb", Typ.Kampf, 100),
					new Attacke("Erdbeben", Typ.Boden, 100),
					new Attacke("Feuerschlag", Typ.Feuer, 75),
					new Attacke("Steinhagel", Typ.Gestein, 75)
				}),
				new Pokemon("Onix", 120, Typ.Gestein, Typ.Boden, new()
				{
					new Attacke("Steinkante", Typ.Gestein, 100),
					new Attacke("Eisenhecke", Typ.Stahl, 60),
					new Attacke("Drachenrute", Typ.Drache, 60),
					new Attacke("Erdstoß", Typ.Boden, 80)
				}),
				new Pokemon("Kicklee", 110, Typ.Kampf, Typ.Kampf, new()
				{
					new Attacke("Fußkick", Typ.Kampf, 85),
					new Attacke("Megakick", Typ.Normal, 120),
					new Attacke("Steinkante", Typ.Gestein, 100),
					new Attacke("Schlagbohrer", Typ.Normal, 80)
				}),
				new Pokemon("Nockchan", 110, Typ.Kampf, Typ.Kampf, new()
				{
					new Attacke("Donnerschlag", Typ.Elektro, 75),
					new Attacke("Eishieb", Typ.Eis, 75),
					new Attacke("Feuerschlag", Typ.Feuer, 75),
					new Attacke("Finte", Typ.Unlicht, 60)
				}),
				new Pokemon("Lucario", 130, Typ.Kampf, Typ.Stahl, new()
				{
					new Attacke("Aurasphäre", Typ.Kampf, 80),
					new Attacke("Metallklaue", Typ.Stahl, 50),
					new Attacke("Psychoklinge", Typ.Psycho, 70),
					new Attacke("Knirscher", Typ.Unlicht, 80)
				})
			}),

            // Trainer 4 – Melanie (Unlicht)
            new Trainer("Melanie", new List<Pokemon>
			{
				new Pokemon("Snibunna", 115, Typ.Unlicht, Typ.Eis, new()
				{
					new Attacke("Eissplitter", Typ.Eis, 40),
					new Attacke("Nachthieb", Typ.Unlicht, 70),
					new Attacke("Eiszahn", Typ.Eis, 65),
					new Attacke("Finte", Typ.Unlicht, 60)
				}),
				new Pokemon("Kramurx", 105, Typ.Unlicht, Typ.Flug, new()
				{
					new Attacke("Schnabel", Typ.Flug, 60),
					new Attacke("Finte", Typ.Unlicht, 60),
					new Attacke("Spukball", Typ.Geist, 80),
					new Attacke("Dunkelnebel", Typ.Gift, 0)
				}),
				new Pokemon("Despotar", 150, Typ.Gestein, Typ.Unlicht, new()
				{
					new Attacke("Knirscher", Typ.Unlicht, 80),
					new Attacke("Steinkante", Typ.Gestein, 100),
					new Attacke("Erdbeben", Typ.Boden, 100),
					new Attacke("Hyperstrahl", Typ.Normal, 150)
				}),
				new Pokemon("Absol", 120, Typ.Unlicht, Typ.Unlicht, new()
				{
					new Attacke("Nachthieb", Typ.Unlicht, 70),
					new Attacke("Psychoklinge", Typ.Psycho, 70),
					new Attacke("Schwerttanz", Typ.Normal, 0),
					new Attacke("Knirscher", Typ.Unlicht, 80)
				}),
				new Pokemon("Hundemon", 120, Typ.Unlicht, Typ.Feuer, new()
				{
					new Attacke("Flammenwurf", Typ.Feuer, 90),
					new Attacke("Finte", Typ.Unlicht, 60),
					new Attacke("Spukball", Typ.Geist, 80),
					new Attacke("Solarstrahl", Typ.Pflanze, 120)
				}),
				new Pokemon("Kleoparda", 110, Typ.Unlicht, Typ.Unlicht, new()
				{
					new Attacke("Finte", Typ.Unlicht, 60),
					new Attacke("Übernahme", Typ.Normal, 0),
					new Attacke("Biss", Typ.Unlicht, 60),
					new Attacke("Zahltag", Typ.Normal, 40)
				})
			}),

			// Champ Rot
			new Trainer("Rot", new List<Pokemon>
			{
				new Pokemon("Bisaflor", 140, Typ.Pflanze, Typ.Gift, new()
				{
					new Attacke("Solarstrahl", Typ.Pflanze, 120),
					new Attacke("Matschbombe", Typ.Gift, 90),
					new Attacke("Egelsamen", Typ.Pflanze, 0),
					new Attacke("Synthese", Typ.Pflanze, 0)
				}),
				new Pokemon("Turtok", 140, Typ.Wasser, Typ.Wasser, new()
				{
					new Attacke("Hydropumpe", Typ.Wasser, 110),
					new Attacke("Eisstrahl", Typ.Eis, 90),
					new Attacke("Kaskade", Typ.Wasser, 80),
					new Attacke("Spiegelcape", Typ.Normal, 65)
				}),
				new Pokemon("Glurak", 140, Typ.Feuer, Typ.Flug, new()
				{
					new Attacke("Flammenwurf", Typ.Feuer, 90),
					new Attacke("Luftschnitt", Typ.Flug, 75),
					new Attacke("Erdbeben", Typ.Boden, 100),
					new Attacke("Drachenpuls", Typ.Drache, 85)
				}),
				new Pokemon("Relaxo", 160, Typ.Normal, Typ.Normal, new()
				{
					new Attacke("Bodyslam", Typ.Normal, 85),
					new Attacke("Erdbeben", Typ.Boden, 100),
					new Attacke("Knuddler", Typ.Fee, 90),
					new Attacke("Erholung", Typ.Psycho, 0)
				}),
				new Pokemon("Lapras", 150, Typ.Wasser, Typ.Eis, new()
				{
					new Attacke("Eisstrahl", Typ.Eis, 90),
					new Attacke("Surfer", Typ.Wasser, 90),
					new Attacke("Gesang", Typ.Normal, 0),
					new Attacke("Donnerblitz", Typ.Elektro, 90)
				}),
				new Pokemon("Pikachu", 120, Typ.Elektro, Typ.Elektro, new()
				{
					new Attacke("Donnerblitz", Typ.Elektro, 90),
					new Attacke("Volt Tackle", Typ.Elektro, 120),
					new Attacke("Ruckzuckhieb", Typ.Normal, 40),
					new Attacke("Eisenschweif", Typ.Stahl, 100)
				})
			})
		};
	}
}