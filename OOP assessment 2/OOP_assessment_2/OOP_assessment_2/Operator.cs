using System;
namespace OOP_assessment_2
{
	public class Operator
	{
        public static void numberoperator()
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
                        add_operand = "+";
                        Console.Write("\t" + add_operand + "\t");
                    }
                    else if (desired_operand == 2)
                    {
                        string minus_operand = desired_operand.ToString();
                        minus_operand = "-";
                        Console.Write("\t" + minus_operand + "\t");
                    }
                    else if (desired_operand == 3)
                    {
                        string mul_operand = desired_operand.ToString();
                        mul_operand = "*";
                        Console.Write("\t" + mul_operand + "\t");
                    }
                    else if (desired_operand == 4)
                    {
                        string div_operand = desired_operand.ToString();
                        div_operand = "/";
                        Console.Write("\t" + div_operand + "\t");
                    }
                }
            }
        }
	}
}

