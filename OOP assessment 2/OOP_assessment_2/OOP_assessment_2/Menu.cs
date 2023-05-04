using System;
using static System.Formats.Asn1.AsnWriter;

namespace OOP_assessment_2
{
	public class Menu
	{

        private readonly IScoring scoring_; //interfaces

        public Menu(IScoring scoring)
        {
            scoring_ = scoring;
        }

        private static IScoring scoring = new Pack();
        Menu menu = new Menu(scoring);

        public static void Showmenu()
		{
            int flag = 1;

            Console.WriteLine("What is your player name\n");
            string name = Console.ReadLine();

            while (flag == 1)
			{
                // Start of the menu

                Console.WriteLine("\n----------What would you like to do?----------\n1. Instructions\n2. Operate on two numbers\n3. Operate on three numbers\n4. Leaderboard\n5. Testing the maths\n6. Quit");

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
                        scoring.updatescore(); //interface
                        Console.WriteLine("Here's your score: " + scoring.Getscore());
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect answer try again!");
                        
                        Console.WriteLine("This is the answer to the question: " + answer);
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
                        scoring.updatescore();
                        Console.WriteLine("Here's your score: " + scoring.Getscore());
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect answer try again!");

                        Console.WriteLine("This is the answer to the question: " + answer);
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

                else if (user_answer == "5") //testing
                {
                    //polymorphism

                    Pack deck = new Pack();

                    Console.WriteLine("Which would you like to test?\n1. Test 2 numbers\n2. Test 3 numbers");
                    string test = Console.ReadLine();

                    Run runningtest;

                    if (test == "1")
                    {
                        runningtest = new trial2numbers();
                    }
                    else if (test == "2")
                    {
                        runningtest = new trial3numbers();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice!");
                        return;
                    }
                    runningtest.runtest();

                }
                else if (user_answer == "6") // quit
                {
                    Newplayer.newplayer(name, scoring.Getscore()); //store player data when they quit

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

