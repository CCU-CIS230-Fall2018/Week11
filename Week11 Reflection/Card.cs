using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Reflection
{
	class Card
	{
		public int Rank { get; set; }
		public string Suit { get; set; }

		public Dictionary<int, string> RankText = new Dictionary<int, string>
		{
			{ 1 , "Ace" },
			{ 2 , "Two" },
			{ 3 , "Three" },
			{ 4 , "Four" },
			{ 5 , "Five" },
			{ 6 , "Six" },
			{ 7 , "Seven" },
			{ 8 , "Eight" },
			{ 9 , "Nine" },
			{ 10 , "Ten" },
			{ 11 , "Jack" },
			{ 12 , "Queen" },
			{ 13 , "King" }
		};
		public Dictionary<string, string> SuitText = new Dictionary<string, string>
		{
			{ "h" , "Hearts" },
			{ "s" , "Spades" },
			{ "d" , "Diamonds" },
			{ "c" , "Clubs" }
		};
		

		public Card(int rank,string suit)
		{
			this.Rank = rank;
			this.Suit = suit;
		}

		public string ShowCard()
		{
			return ($"{this.RankText[this.Rank]} of {this.SuitText[this.Suit]}");
		}


	}
}
