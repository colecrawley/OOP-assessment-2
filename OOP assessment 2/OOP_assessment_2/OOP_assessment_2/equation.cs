using System;
namespace OOP_assessment_2
{
	public class equation
	{
		public static int Compute2(string sign, int number_1, int number_2)
		{
            /*Pack.DealCard(1);
			foreach (Card item in Pack.dealt_cards.Distinct().ToList())
			{
				if (item.Suit == 1)
				{
					sign = item.Suit.ToString();
					sign = "+";
				}
				else if (item.Suit == 2)
				{
					sign = item.Suit.ToString();
					sign = "-";
				}
				else if (item.Suit == 3)
				{
					sign = item.Suit.ToString();
					sign = "*";
				}
				else if (item.Suit == 4)
				{
					sign = item.Suit.ToString();
					sign = "/";
				}

			}*/

                //turn Number into either float or int

            if (sign == "+")
			{
				return (int)(number_1 + number_2);
			}
			else if (sign == "-")
			{
				return (int)(number_1 - number_2);
			}
			else if (sign == "*")
			{
				return (int)(number_1 * number_2);
			}
			else if (sign == "/")
			{
				return (int)(float)(number_1 / number_2);
			}
			else
			{
				throw new ArgumentException("Invalid operator selected: " + sign);
			}

		}
	}
}

