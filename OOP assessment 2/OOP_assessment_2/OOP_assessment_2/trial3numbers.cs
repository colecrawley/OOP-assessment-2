using System;
namespace OOP_assessment_2
{
	public class trial3numbers : Run
	{
        public override void runtest() //polymorphism turning base class to perform testing on deal 3 numbers
        {
            Console.WriteLine("----------Testing the deal 5 cards maths to output correctly----------\n");

            decimal answer_2 = DealCards.deal5cards();

            Console.WriteLine("\tThis is the answer: \t" + answer_2);
        }
    }
}

