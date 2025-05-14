public class Attacke
{
	public string Name { get; }
	public Typ Typ { get; }
	public int Schaden { get; }
	public object Stärke { get; internal set; }
	public object Genauigkeit { get; internal set; }

	public Attacke(string name, Typ typ, int schaden)
	{
		Name = name;
		Typ = typ;
		Schaden = schaden;
	}
}