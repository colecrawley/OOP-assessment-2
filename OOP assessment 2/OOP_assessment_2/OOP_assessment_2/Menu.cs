using System;
namespace OOP_assessment_2
{
	public class Menu
	{
		public static void Showmenu()
		{
			int flag = 1;

			while (flag == 1)
			{
                // Start of the menu
                Console.WriteLine("----------What would you like to do?----------\n1. Instructions\n2. Operate on two numbers\n3. Operate on three numbers\n4. Quit");

                string user_answer = Console.ReadLine();

				if (user_answer == "1")
				{
					Console.WriteLine("\nThis is a maths tutor application. You have the choice of operating on either two or three numbers of your choice.\nYou are to input the correct answer, if you get it wrong, a message will display if it is incorrect.");

				}

				else if (user_answer == "2")
				{
					//place in
					Console.WriteLine("Running choice 2");
				}

				else if (user_answer == "3")
				{
					Console.WriteLine("Running choice 3");
				}

				else if (user_answer == "4")
				{
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

