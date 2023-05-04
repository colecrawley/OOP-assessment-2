using System;
namespace OOP_assessment_2
{
	public class Newplayer
	{
		public static void newplayer(string name, int score) //stores the new player data into the leaderboard
		{

            //keeps track of the score throughout the program and username

            List<Leaderboard> scores = Leaderboard.Readleaderboard("leaderboard.rtf");

            Leaderboard newscore = new Leaderboard
            {
                Username = name,
                Scorenum = score
            };
            scores.Add(newscore);
            scores = scores.OrderByDescending(s => s.Scorenum).ToList();

            Leaderboard.WriteLeaderboard(scores, "leaderboard.rtf"); //write score to txt file
        }

	}
}

