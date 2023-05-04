using System;
namespace OOP_assessment_2
{
	public class Leaderboard
	{
		public string Username { get; set; }
		public int Scorenum { get; set; }

		public static List<Leaderboard> Readleaderboard(string filepath) //read leaderboard
		{
            List<Leaderboard> scores = new List<Leaderboard>();

			string[] lines = File.ReadAllLines(filepath); //stores lines of info into variable


			foreach (string line in lines)
			{
				string[] parts = line.Split(",");

				if (parts.Length == 2)
				{
					string username = parts[0];
					int scorenum;
					if (int.TryParse(parts[1], out scorenum))
					{
						scores.Add(new Leaderboard { Username = username, Scorenum = scorenum }); // displays username and scorea
					}
				}
			}
			return scores;

        }

		public static void WriteLeaderboard(List<Leaderboard> scores, string filepath)
		{
			List<string> lines = new List<string>();

			foreach (Leaderboard score in scores)
			{
				string line = $"{score.Username}, {score.Scorenum}";
				lines.Add(line); // adds the username and score to the text file
			}

			File.WriteAllLines(filepath, lines);
		}

	}
}

