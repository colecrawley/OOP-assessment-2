using System;
namespace OOP_assessment_2
{
	public class Test : DealCards
	{
		public void trialsfor2()
		{
			Console.WriteLine("----------Testing the deal 3 cards maths to output correctly----------\n");

			DealCards.deal3cards();

            decimal answer = DealCards.deal3cards();

            Console.WriteLine("\tThis is the answer: \t" + answer);

        }

		public void trialsfor3()
		{
            Console.WriteLine("----------Testing the deal 5 cards maths to output correctly----------\n");

            DealCards.deal5cards();

            decimal answer_2 = DealCards.deal5cards();

            Console.WriteLine("\tThis is the answer: \t" + answer_2);
        }


    }
}

