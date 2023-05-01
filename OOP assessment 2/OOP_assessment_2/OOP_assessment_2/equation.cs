using System;
namespace OOP_assessment_2
{
	public class equation
	{
		public static decimal Compute2(string sign, decimal number_1, decimal number_2)
		{

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
				return (number_1 / number_2);
			}
			else
			{
				throw new ArgumentException("Invalid operator selected: " + sign);
			}

		}

		public static decimal Compute3(string sign_1, string sign_2, decimal number_1, decimal number_2, decimal number_3)
		{
			if (sign_1 == "+" && sign_2 == "-")
			{
				return (int)(number_1 + number_2 - number_3);
			}
			else if (sign_1 == "+" && sign_2 == "*")
			{
				return (int)(number_1 + number_2 * number_3);
			}
			else if (sign_1 == "+" && sign_2 == "/")
			{
				return (int)(double)(number_1 + number_2 / number_3);
			}
			else if (sign_1 == "+" && sign_2 == "+")
			{
				return (int)(number_1 + number_2 + number_3);
			}
			else if (sign_1 == "-" && sign_2 == "+")
			{
				return (int)(number_1 - number_2 + number_3);
			}
			else if (sign_1 == "-" && sign_2 == "-")
			{
				return (int)(number_1 - number_2 - number_3);
			}
			else if (sign_1 == "-" && sign_2 == "*")
			{
				return (int)(number_1 - number_2 * number_3);
			}
			else if (sign_1 == "-" && sign_2 == "/")
			{
				return (number_1 - number_2 / number_3);
			}
			else if (sign_1 == "*" && sign_2 == "+")
			{
				return (int)(number_1 * number_2 + number_3);
			}
			else if (sign_1 == "*" && sign_2 == "-")
			{
				return (int)(number_1 * number_2 - number_3);
			}
			else if (sign_1 == "*" && sign_2 == "*")
			{
				return (int)(number_1 * number_2 * number_3);
			}
			else if (sign_1 == "*" && sign_2 == "/")
			{
				return (number_1 * number_2 / number_3);
			}
			else if (sign_1 == "/" && sign_2 == "+")
			{
				return (number_1 / number_2 + number_3);
			}
			else if (sign_1 == "/" && sign_2 == "-")
			{
				return (number_1 / number_2 - number_3);
			}
			else if (sign_1 == "/" && sign_2 == "*")
			{
				return (number_1 / number_2 * number_3);
			}
			else if (sign_1 == "/" && sign_2 == "/")
			{
				return (number_1 / number_2 / number_3);
			}
			else
			{
                throw new ArgumentException("Invalid operator selected: " + sign_1 + " and " + sign_2);
            }
        }
	}
}

