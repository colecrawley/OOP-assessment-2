using System;
namespace OOP_assessment_2
{
	public class Operator
	{
        public static string numberoperator() //changes 1-4 to mathematical symbols
        {
            int desired_operand = 0; //rename this

            Pack.DealCard(1);
            foreach (Card item in Pack.dealt_cards.Distinct().ToList())
            {
                if (item.Suit < 5)
                {
                    desired_operand = item.Suit;

                    if (desired_operand == 1)
                    {
                        string add_operand = desired_operand.ToString();
                        //add_operand = "+";
                        Console.Write("\t" + "+" + "\t");
                        return "+";
                    }
                    else if (desired_operand == 2)
                    {
                        string minus_operand = desired_operand.ToString();
                       // minus_operand = "-";
                        Console.Write("\t" + "-" + "\t");
                        return "-";
                    }
                    else if (desired_operand == 3)
                    {
                        string mul_operand = desired_operand.ToString();
                        Console.Write("\t" + "*" + "\t");
                        return "*";
                    }
                    else if (desired_operand == 4)
                    {
                        string div_operand = desired_operand.ToString();
                        Console.Write("\t" + "/" + "\t");
                        return "/";
                    }
                }
            }
            return null;
        }
	}
}

