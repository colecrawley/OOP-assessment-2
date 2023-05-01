using System;
namespace OOP_assessment_2
{
	public class Number
	{
		public static void numbervalue()
		{
            Pack.DealCard(1);
            foreach (Card item in Pack.dealt_cards.Distinct().ToList())
            {
                Console.Write(item.Value);
            }
        }
		
	}
}

