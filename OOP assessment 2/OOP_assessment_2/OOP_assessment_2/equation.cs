using System;
namespace OOP_assessment_2
{
	public class equation
	{
		public static decimal Compute2(string sign, decimal number_1, decimal number_2) //computation for two numbers
		{

            if (sign == "+")
			{
				return (number_1 + number_2);
			}
			else if (sign == "-")
			{
				return (number_1 - number_2);
			}
			else if (sign == "*")
			{
				return (number_1 * number_2);
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

		public static decimal Compute3(string sign_1, string sign_2, decimal number_1, decimal number_2, decimal number_3) // computation for three numbers
		{
			// Added extra PEMDAS rules to enforce c# to use them correctly

			if (sign_1 == "+" && sign_2 == "-")
			{
				decimal number_4 = number_1 + number_2;
				decimal result = number_4 - number_3;
				return result;
			}
			else if (sign_1 == "+" && sign_2 == "*")
			{
				decimal number_4 = number_2 * number_3;
				decimal result = number_1 + number_4;
				return result;
			}
			else if (sign_1 == "+" && sign_2 == "/")
			{
                decimal number_4 = number_2 / number_3;
                decimal result = number_1 + number_4;
                return result;
            }
			else if (sign_1 == "+" && sign_2 == "+")
			{
                return (number_1 + number_2 + number_3);
            }
			else if (sign_1 == "-" && sign_2 == "+")
			{
                decimal number_4 = number_2 + number_3;
                decimal result = number_1 - number_4;
                return result;
            }
			else if (sign_1 == "-" && sign_2 == "-")
			{
				return (number_1 - number_2 - number_3);
			}
			else if (sign_1 == "-" && sign_2 == "*")
			{
                decimal number_4 = number_2 * number_3;
                decimal result = number_1 - number_4;
                return result;
            }
			else if (sign_1 == "-" && sign_2 == "/")
			{
                decimal number_4 = number_2 / number_3;
                decimal result = number_1 - number_4;
                return result;
            }
			else if (sign_1 == "*" && sign_2 == "+")
			{
                decimal number_4 = number_1 * number_2;
                decimal result = number_4 + number_3;
                return result;
            }
			else if (sign_1 == "*" && sign_2 == "-")
			{
                decimal number_4 = number_1 * number_2;
                decimal result = number_4 - number_3;
                return result;
            }
			else if (sign_1 == "*" && sign_2 == "*")
			{
                return (number_1 * number_2 * number_3);
            }
			else if (sign_1 == "*" && sign_2 == "/")
			{
                decimal number_4 = number_1 * number_2;
                decimal result = number_4 / number_3;
                return result;
            }
			else if (sign_1 == "/" && sign_2 == "+")
			{
                decimal number_4 = number_1 / number_2;
                decimal result = number_4 + number_3;
                return result;
            }
			else if (sign_1 == "/" && sign_2 == "-")
			{
                decimal number_4 = number_1 / number_2;
                decimal result = number_4 - number_3;
                return result;
            }
			else if (sign_1 == "/" && sign_2 == "*")
			{
                decimal number_4 = number_2 * number_3;
                decimal result = number_1 / number_4;
                return result;
            }
			else if (sign_1 == "/" && sign_2 == "/")
			{
				return (number_1 / number_2 / number_3);
			}
			else
			{
                throw new ArgumentException("Invalid operator selected: " + sign_1 + " and " + sign_2); // just in case there is a wrong operator
            }
        }
	}
}

