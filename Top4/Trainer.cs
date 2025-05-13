using System.Collections.Generic;

public class Trainer
{
	public string Name { get; }
	public List<Pokemon> Team { get; }

	public Trainer(string name, List<Pokemon> team)
	{
		Name = name;
		Team = team;
	}
}
