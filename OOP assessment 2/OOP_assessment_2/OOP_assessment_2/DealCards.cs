using System;
using System.Xml.Linq;

namespace OOP_assessment_2
{
	public class DealCards
	{

        public static decimal deal3cards()
        {

            Pack.ShuffleCardPack(1); // inheritance to produce the randomness of the cards/equations

            //show the equation
            int opnum_1 = Number.numbervalue(); //first number term

            //Operator.numberoperator();

            string opsign = Operator.numberoperator(); // operator


            int opnum_2 = Number.numbervalue(); //second number term

            decimal answer = Decimal.Round(equation.Compute2(opsign, opnum_1, opnum_2), 1); // answer
            return answer;
        }
        

		public static decimal deal5cards()
		{

            Pack.ShuffleCardPack(1); //inheritance

            int opnum_1 = Number.numbervalue();

            string opsign_1 = Operator.numberoperator();

            int opnum_2 = Number.numbervalue();

            string opsign_2 = Operator.numberoperator();

            int opnum_3 = Number.numbervalue();

            decimal answer = Decimal.Round(equation.Compute3(opsign_1, opsign_2, opnum_1, opnum_2, opnum_3),1); // answer
            return answer;
        }

	}
}

