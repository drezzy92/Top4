using System.Collections.Generic;
public class Trainer
{
	public string Name;             
	public List<Pokemon> Team;

	//Erstellt Trainer mit Name Team
	public Trainer(string name, List<Pokemon> team)
	{
		Name = name;
		Team = team;
	}
}
