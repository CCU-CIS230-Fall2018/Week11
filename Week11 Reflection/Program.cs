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
			Card card = new Card(1, "d");


			var deck = Activator.CreateInstance(typeof(CardDeck)) as CardDeck;
			var deck1 = new CardDeck();
			Console.WriteLine(deck.Deck[0].ShowCard());
			Console.WriteLine(deck1.Deck[0].ShowCard());

		}
	}
}
