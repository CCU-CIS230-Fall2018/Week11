using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Reflection
{
	class CardDeck
	{
		private Card TestCard = new Card(1, "h");
		public Card[] Deck = new Card[52];
		public CardDeck()
		{
			short iterator = 0;
			foreach (KeyValuePair<string, string> suit in TestCard.SuitText)
			{
				foreach (KeyValuePair<int,string> rank in TestCard.RankText)
				{
					this.Deck[iterator] = new Card(rank.Key, suit.Key);
					iterator++;
				}
			}
		}

		public Card[] GetDeck()
		{
			return this.Deck;
		}
		// public List<Card> Deck = new List<Card>();

	}
}
