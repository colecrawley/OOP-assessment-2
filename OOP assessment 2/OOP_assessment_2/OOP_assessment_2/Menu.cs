using System;
using static System.Formats.Asn1.AsnWriter;

namespace OOP_assessment_2
{
	public class Menu
	{
		
        public static void Showmenu()
		{
			int Highscore = 0;
			int flag = 1;

            Console.WriteLine("What is your player name\n");
            string name = Console.ReadLine();

            while (flag == 1)
			{
                // Start of the menu

                Console.WriteLine("\n----------What would you like to do?----------\n1. Instructions\n2. Operate on two numbers\n3. Operate on three numbers\n4. Leaderboard\n5. Quit");

                string user_answer = Console.ReadLine();

				if (user_answer == "1")
				{
					Console.WriteLine("\nThis is a maths tutor application. You have the choice of operating on either two or three numbers of your choice, The numbers have to be from 1-13.\nYou are to input the correct answer, if you get it wrong, a message will display if it is incorrect.");

				}

				else if (user_answer == "2") //operate on two different numbers
				{

					Pack deck = new Pack(); // initialize the pack

                    decimal answer = DealCards.deal3cards();

                    Console.WriteLine("\nWhat is the answer?\n");
                    string user_ans = Console.ReadLine();
                    decimal ans = decimal.Parse(user_ans);

                    if (ans == answer)
                    {
                        Console.WriteLine("\nYou got the right answer!\n");
						Highscore++;
                        Console.WriteLine("Here's your score: " + Highscore);
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect answer try again!");
                    }
                }

				else if (user_answer == "3") //operate on three different numbers
				{

					Pack deck = new Pack();

					decimal answer = DealCards.deal5cards();

                    Console.WriteLine("\nWhat is the answer?\n");
                    string user_ans = Console.ReadLine();
                    decimal ans = decimal.Parse(user_ans);

                    if (ans == answer)
                    {
                        Console.WriteLine("\nYou got the right answer!\n");
                        Highscore++;
                        Console.WriteLine("Here's your score: " + Highscore);
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect answer try again!");
                    }
                }

				else if (user_answer == "4") //leaderboard
				{

					//leaderboard/text file


                    List<Leaderboard> scores = Leaderboard.Readleaderboard("leaderboard.rtf"); //read the leaderboard

					foreach (Leaderboard score in scores)
					{
						Console.WriteLine("Player: " + score.Username);
						Console.WriteLine("Score: " + score.Scorenum);
						Console.WriteLine();
					}
				}

				else if (user_answer == "5") //quit
				{

                    Newplayer.newplayer(name, Highscore); //store player data when they quit

                    Console.WriteLine("Thank you, come again!");
                    Console.ReadKey();
                    flag = 0;
                    break;

                }

				else
				{
					Console.WriteLine("Invalid selection. Choose again!");
				}
			}
		}
	}
}

