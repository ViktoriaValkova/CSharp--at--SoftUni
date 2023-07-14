namespace P05.TeamworkProjects.SecondVersion__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            CreateTeam(teams);

            JoinTeams(teams);

            PrintValidTeams(teams);

            PrintDisbandedTeams(teams);
        }

        private static void PrintDisbandedTeams(List<Team> teams)
        {
            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();

            Console.WriteLine("Teams to disband:");

            foreach (Team team in teamsToDisband)
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }

        private static void PrintValidTeams(List<Team> teams)
        {
            List<Team> teamsWithMembers = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            foreach (Team team in teamsWithMembers)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        static void CreateTeam(List<Team> teams)
        {
            int teamsCnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamsCnt; i++)
            {
                string[] command = Console.ReadLine().Split('-').ToArray();
                string creator = command[0];
                string name = command[1];

                if (TeamExist(teams, name))
                {
                    Console.WriteLine($"Team {name} was already created!");
                }
                else if (IsCreatorNew(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team currentTeam = new Team(name, creator);
                    teams.Add(currentTeam);
                    Console.WriteLine($"Team {name} has been created by {creator}!");
                }
            }
        }
        static bool TeamExist(List<Team> teams, string teamName)
        {
            return teams.Any(t => t.TeamName == teamName);
        }
        static bool IsCreatorNew(List<Team> teams, string creator)
        {
            return teams.Any(t => t.Creator == creator);
        }
        static void JoinTeams(List<Team> list)
        {


            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] command = input.Split("->").ToArray();

                string player = command[0];
                string teamName = command[1];

                if (TeamExist(list, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMember(list, player))
                {
                    Console.WriteLine($"Member {player} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = list.First(t => t.TeamName == teamName);
                    teamToJoin.AddMember(player);
                }
            }

        }

        static bool AlreadyAMember(List<Team> teams, string member)
        {
            return teams.Any(t => t.Members.Contains(member)) ||
                   teams.Any(t => t.Creator == member);
        }

        public class Team
        {
            public Team(string teamName, string creator)
            {
                this.Creator = creator;
                this.TeamName = teamName;
                this.members = new List<string>(); // important, otherwise Null 
            }

            //   Always do lists/array like so (as field): 
            private readonly List<string> members;

            public string
                TeamName
            { get; private set; } // here private set, because we dont need to change the name of the team

            public string Creator { get; private set; } // same logic

            // lists are always just get; Also called get-only property; the property just returns the information in the private field (members)
            // to be completly right, should be:
            //public IReadOnlyCollection<string> Memberя

            public List<string> Members
                => this.members;

            public void AddMember(string memberName)
            {
                this.members.Add(memberName);
            }
        }
    }
}