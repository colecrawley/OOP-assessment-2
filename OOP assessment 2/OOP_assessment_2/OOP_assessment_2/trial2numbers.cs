using System;
namespace OOP_assessment_2
{
	public class trial2numbers : Run
	{
        public override void runtest() //polymorphism turning base class to perform testing on deal 2 numbers
        {
            Console.WriteLine("----------Testing the deal 3 cards maths to output correctly----------\n");

            decimal answer = DealCards.deal3cards();

            Console.WriteLine("\tThis is the answer: \t" + answer);
        }
    }
}

