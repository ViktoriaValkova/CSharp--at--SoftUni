using P05.FootballTeamGenerator.Models;

namespace P05.FootballTeamGenerator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = string.Empty;
			List<Team> teams = new List<Team>();
			while ((input = Console.ReadLine()) != "END")
			{
				try
				{
					string[] cmdArg = input.Split(";");
							string teamName= cmdArg[1];

					switch (cmdArg[0])
					{
						case "Team":
							teams.Add(new Team(teamName));
							break;
						case "Add":
							string playerName = cmdArg[2];
							int endurance = int.Parse(cmdArg[3]);
							int sprint = int.Parse(cmdArg[4]);
							int dribble = int.Parse(cmdArg[5]);
							int passing = int.Parse(cmdArg[6]);
							int shooting = int.Parse(cmdArg[7]);

							Team currentTeam = teams.Find(t => t.Name == teamName);
							if (currentTeam == null) 
							{
								Console.WriteLine($"Team {teamName} does not exist.");
								continue;
							}
							currentTeam.AddPlayer(new Player(playerName,endurance,sprint,dribble,passing,shooting));
							break;
						case "Remove":
							string playerNameRem = cmdArg[2];
							Team currentTeamRem = teams.Find(t => t.Name == teamName);
							currentTeamRem.RemovePlayer(playerNameRem);
							break;
						case "Rating":
							Team currentTeamRating = teams.Find(t => t.Name == teamName);
							if (currentTeamRating == null)
							{
								Console.WriteLine($"Team {teamName} does not exist.");
								continue;
							}

							Console.WriteLine($"{teamName} - {currentTeamRating.Rating}");
							break;

					}
				}
				catch(ArgumentException ex) 
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
	}
}