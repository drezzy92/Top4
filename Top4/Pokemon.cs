﻿using System.Collections.Generic;

public class Pokemon
{
	public string Name { get; set; }
	public int MaxKP { get; set; }
	public int AktuelleKP { get; set; }
	public Typ Typ1 { get; set; }
	public Typ? Typ2 { get; set; }
	public List<Attacke> Attacken { get; }
	public int KP { get; internal set; }
	public object Angriff { get; internal set; }
	public object Typ { get; internal set; }

	public Pokemon(string name, int maxKP, Typ typ1, Typ typ2, List<Attacke> attacken)
	{
		Name = name;
		MaxKP = maxKP;
		AktuelleKP = maxKP;
		Typ1 = typ1;
		Typ2 = typ2;
		Attacken = attacken;
	}

	public bool IstBesiegt() => AktuelleKP <= 0;
}