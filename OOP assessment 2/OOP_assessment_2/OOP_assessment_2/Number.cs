﻿using System;
namespace OOP_assessment_2
{
	public class Number : Pack
	{
        
   
		public static int numbervalue() // takes value from Value:Suit pair from the card
		{
            int num = 0;
            Pack.DealCard(1);
            foreach (Card item in Pack.dealt_cards.Distinct().ToList())
            {
                Console.Write(item.Value);
                num = item.Value;
            }
            return num;

        }
		
	}
}

