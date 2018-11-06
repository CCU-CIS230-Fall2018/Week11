using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Reflection
{
	class Program
	{
		static void Main(string[] args)
		{
			CardDeck newDeck = new CardDeck();
			Card[] newerDeck = newDeck.GetDeck();
			foreach (Card card in newerDeck)
			{
				Console.WriteLine(card.ShowCard());
			}
		}
	}
}
