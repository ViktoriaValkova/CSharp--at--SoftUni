namespace P05.TeamworkProjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            int teamsCnt = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();


            for (int i = 0; i < teamsCnt; i++)
            {
                string[] command = Console.ReadLine().Split('-').ToArray();
                string creator = command[0];
                string name = command[1];
                Team currentTeam = new Team(name, creator);

                if (IsTeamNameNew(teams, name) && IsCreatorNew(teams, creator))
                {
                    currentTeam.CreateTeam(teams, creator, name, currentTeam);
                    currentTeam.Members = new List<string>(); 
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] command = input.Split("->").ToArray();

                string player = command[0];
                string teamName = command[1];

                if (DoesTeamExist(teams, teamName) && IsNotAlreadyMember(teams, player, teamName))
                {
                    Team team = teams.Find(team => team.TeamName == teamName);

                    if (team.Creator != player)
                    {
                        team.Members.Add(player);
                    }
                    else
                    {
                        Console.WriteLine($"Member {player} cannot join team {teamName}!");
                    }
                }
            }
            List<Team> teamsToClose = teams.Where(t => t.Members.Count==0).ToList();
            
            teamsToClose = teamsToClose.OrderBy(team => team.TeamName).ToList();

            teams = teams.Where(t => t.Members.Count>0).ToList();
            teams = teams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.TeamName).ToList();

            foreach (Team team in teams)
            {
                Console.WriteLine($"{team.TeamName}"); 
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in teamsToClose)
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }

        static bool DoesTeamExist(List<Team> teams, string teamName)
        {
            foreach (Team team in teams)
            {
                if (team.TeamName == teamName)
                {
                    return true;
                }
            }

            Console.WriteLine($"Team {teamName} does not exist!");
            return false;
        }

        static bool IsNotAlreadyMember(List<Team> teams, string player, string teamName)
        {
            foreach (Team team in teams)
            {
                if (team.Members.Contains(player))
                {
                    Console.WriteLine($"Member {player} cannot join team {teamName}!");
                    return false;
                }
            }

            return true;
        }

        static bool IsCreatorNew(List<Team> teams, string creator)
        {
            foreach (Team team in teams)
            {
                if (team.Creator == creator)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    return false;
                }
            }

            return true;
        }

        static bool IsTeamNameNew(List<Team> teams, string name)
        {
            foreach (Team team in teams)
            {
                if (team.TeamName == name)
                {
                    Console.WriteLine($"Team {name} was already created!");
                    return false;
                }
            }

            return true;
        }
    }

    public class Team
    {
        public Team(string teamName, string creator)
        {
            this.Creator = creator;
            this.TeamName = teamName;
        }

        public string TeamName { get; private set; }  // here private set, because we dont need to change the name of the team

        public string Creator { get; private set; }  // same logic

        public List<string> Members { get; set; }
        public void CreateTeam(List<Team> teams, string creator, string teamName, Team currentTeam)
        {
            Console.WriteLine($"Team {this.TeamName} has been created by {this.Creator}!");
            teams.Add(currentTeam);

        }
    }
}
