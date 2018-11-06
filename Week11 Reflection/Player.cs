using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Reflection
{
	class Player
	{
		public string Name { get; set; }
		private List<Card> Hand = new List<Card>();

		public Player(string name)
		{
			name = this.Name;
		}

		public void AddCard(Card card)
		{
			Hand.Add(card);
		}

		public List<Card> PlayerHand()
		{
			return this.Hand;
		}
	}
}
