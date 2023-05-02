using System;
namespace OOP_assessment_2
{
	public class Leaderboard
	{
		public string Username { get; set; }
		public int Scorenum { get; set; }

		public static List<Leaderboard> Readleaderboard(string filepath)
		{
            List<Leaderboard> scores = new List<Leaderboard>();

			string[] lines = File.ReadAllLines(filepath);


			foreach (string line in lines)
			{
				string[] parts = line.Split(",");

				if (parts.Length == 2)
				{
					string username = parts[0];
					int scorenum;
					if (int.TryParse(parts[1], out scorenum))
					{
						scores.Add(new Leaderboard { Username = username, Scorenum = scorenum });
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
				lines.Add(line);
			}

			File.WriteAllLines(filepath, lines);
		}

	}
}

