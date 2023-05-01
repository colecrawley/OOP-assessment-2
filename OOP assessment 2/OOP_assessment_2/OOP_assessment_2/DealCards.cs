using System;
namespace OOP_assessment_2
{
	public class DealCards
	{
		public static void deal3cards()
		{

            //show the equation
            int opnum_1 = Number.numbervalue();

            //Operator.numberoperator();

            string opsign = Operator.numberoperator();


            int opnum_2 = Number.numbervalue();
            
            int answer = equation.Compute2(opsign, opnum_1, opnum_2); // answer

            Console.WriteLine("\nWhat is the answer?\n");
            string user_ans = Console.ReadLine();
            int ans = int.Parse(user_ans);

            if (ans == answer)
            {
                Console.WriteLine("\nYou got the right answer!");
            }
            else
            {
                Console.WriteLine("\nIncorrect answer try again!");
            }


        }

		public static void deal5cards()
		{
            Number.numbervalue();

            Operator.numberoperator();

            Number.numbervalue();

            Operator.numberoperator();

            Number.numbervalue();
        }

	}
}

