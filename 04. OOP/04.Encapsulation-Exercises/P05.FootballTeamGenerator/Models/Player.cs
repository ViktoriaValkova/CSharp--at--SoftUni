using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.FootballTeamGenerator.Models
{
	internal class Player
	{
		private string ExcMessage = "{0} should be between 0 and 100.";
		private int endurance;
		private int sprint;
		private int dribble;
		private int passing;
		private int shooting;
		private string name;

		public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
		{
			Name=name;
			Endurance=endurance;
			Sprint=sprint;
			Dribble=dribble;
			Passing=passing;
			Shooting=shooting;
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
		private int Endurance
		{
			get => endurance;
			set
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException(string.Format(ExcMessage, nameof(Endurance))); 
				}
				endurance = value;
			}
		}
		private int Sprint
		{
			get => sprint;
			set
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException(string.Format(ExcMessage, nameof(Sprint)));
				}
				sprint=value;
			}
		}

		private int Dribble
		{
			get => dribble;
			set
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException(string.Format(ExcMessage, nameof(Dribble)));
				}
				dribble=value;
			}
		}
		private int Passing 
		{
			get => passing;
			set
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException(string.Format(ExcMessage, nameof(Passing)));
				}
				passing=value;
			}
		}
		private int Shooting
		{
			get => shooting;
			set
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException(string.Format(ExcMessage, nameof(Shooting)));
				}
				shooting=value;
			}
		}

		public double SkillLevel()
		{
			return (Shooting + Sprint + Dribble + Endurance + Passing)/(double)5;
		}
	}
}
