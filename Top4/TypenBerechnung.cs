using System.Collections.Generic;

public static class TypenBerechnung
{
	private static Dictionary<(Typ, Typ), double> effektivitaet = new Dictionary<(Typ, Typ), double>
	{
        // Super effektiv
        {(Typ.Feuer, Typ.Pflanze), 2.0},
		{(Typ.Wasser, Typ.Feuer), 2.0},
		{(Typ.Pflanze, Typ.Wasser), 2.0},
		{(Typ.Elektro, Typ.Wasser), 2.0},
		{(Typ.Eis, Typ.Drache), 2.0},
		{(Typ.Kampf, Typ.Normal), 2.0},
		{(Typ.Gift, Typ.Pflanze), 2.0},
		{(Typ.Boden, Typ.Feuer), 2.0},
		{(Typ.Flug, Typ.Kampf), 2.0},
		{(Typ.Psycho, Typ.Kampf), 2.0},
		{(Typ.Käfer, Typ.Pflanze), 2.0},
		{(Typ.Gestein, Typ.Flug), 2.0},
		{(Typ.Geist, Typ.Psycho), 2.0},
		{(Typ.Drache, Typ.Drache), 2.0},
		{(Typ.Unlicht, Typ.Psycho), 2.0},
		{(Typ.Stahl, Typ.Eis), 2.0},
		{(Typ.Fee, Typ.Drache), 2.0},

        // Weniger effektiv
        {(Typ.Feuer, Typ.Wasser), 0.5},
		{(Typ.Wasser, Typ.Pflanze), 0.5},
		{(Typ.Pflanze, Typ.Feuer), 0.5},
		{(Typ.Elektro, Typ.Pflanze), 0.5},
		{(Typ.Eis, Typ.Feuer), 0.5},
		{(Typ.Kampf, Typ.Gift), 0.5},
		{(Typ.Gift, Typ.Gift), 0.5},
		{(Typ.Boden, Typ.Pflanze), 0.5},
		{(Typ.Flug, Typ.Gestein), 0.5},
		{(Typ.Psycho, Typ.Stahl), 0.5},
		{(Typ.Käfer, Typ.Feuer), 0.5},
		{(Typ.Gestein, Typ.Stahl), 0.5},
		{(Typ.Drache, Typ.Stahl), 0.5},
		{(Typ.Unlicht, Typ.Kampf), 0.5},
		{(Typ.Fee, Typ.Feuer), 0.5},

        // Keine Wirkung
        {(Typ.Elektro, Typ.Boden), 0.0},
		{(Typ.Normal, Typ.Gestein), 0.0},
		{(Typ.Kampf, Typ.Geist), 0.0},
		{(Typ.Psycho, Typ.Unlicht), 0.0},
		{(Typ.Gift, Typ.Stahl), 0.0},
		{(Typ.Drache, Typ.Fee), 0.0}
	};

	// Berechnet Effektivität
	public static double Berechne(Typ angriffsTyp, Typ verteidiger1, Typ? verteidiger2)
	{
		// 1ter Typ des Verteidigers
		double faktor1 = 1.0;
		if (effektivitaet.ContainsKey((angriffsTyp, verteidiger1)))
		{
			faktor1 = effektivitaet[(angriffsTyp, verteidiger1)];
		}

		// 2ter Typ
		double faktor2 = 1.0;
		if (verteidiger2.HasValue && effektivitaet.ContainsKey((angriffsTyp, verteidiger2.Value)))
		{
			faktor2 = effektivitaet[(angriffsTyp, verteidiger2.Value)];
		}

		// Gesamtfaktor = beide Typen kombiniert
		return faktor1 * faktor2;
	}
}