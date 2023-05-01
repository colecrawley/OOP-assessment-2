using System;
namespace OOP_assessment_2
{
	public class DealCards : Pack
	{
		public static void deal3cards()
		{
            Pack.ShuffleCardPack(1);

            //show the equation
            int opnum_1 = Number.numbervalue();

            //Operator.numberoperator();

            string opsign = Operator.numberoperator();


            int opnum_2 = Number.numbervalue();
            
            decimal answer = Decimal.Round(equation.Compute2(opsign, opnum_1, opnum_2),1); // answer
            //Console.WriteLine("\n" + answer);

            Console.WriteLine("\nWhat is the answer?\n");
            string user_ans = Console.ReadLine();
            decimal ans = decimal.Parse(user_ans);

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
            int opnum_1 = Number.numbervalue();

            string opsign_1 = Operator.numberoperator();

            int opnum_2 = Number.numbervalue();

            string opsign_2 = Operator.numberoperator();

            int opnum_3 = Number.numbervalue();

            decimal answer = Decimal.Round(equation.Compute3(opsign_1, opsign_2, opnum_1, opnum_2, opnum_3),1); // answer
            Console.WriteLine("\nWhat is the answer?\n");
            string user_ans = Console.ReadLine();
            decimal ans = decimal.Parse(user_ans);

            if (ans == answer)
            {
                Console.WriteLine("\nYou got the right answer!");
            }
            else
            {
                Console.WriteLine("\nIncorrect answer try again!");
            }
        }

	}
}

