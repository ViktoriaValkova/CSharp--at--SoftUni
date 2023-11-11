using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.FootballTeamGenerator.Models
{
	internal class Team
	{
		private string name;
		private double rating;
		private readonly List<Player> players;

		public Team(string name)
		{
			Name = name;
			players = new List<Player>();
		}

		public string Name
		{
			get => name;
			private set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("A name should not be empty.");
				}
				name = value;
			}
		}
		public double Rating => Math.Round(GetRating());


		public void RemovePlayer(string playerName)
		{
			Player player = this.players.FirstOrDefault(p=>p.Name==playerName.Trim());
			if (player==null)
			{ 
				Console.WriteLine($"Player {playerName} is not in {Name} team.");
			}
			else
			{
			players.Remove(player);
			}
		}

		public void AddPlayer(Player player)
		{
			players.Add(player);
		}

		private double GetRating()
		{
			double result = 0;
			foreach (Player player in players)
			{
				result += player.SkillLevel();
			}
			return result;
		}
	}
}
