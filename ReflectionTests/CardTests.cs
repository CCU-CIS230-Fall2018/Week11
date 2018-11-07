using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week11_Reflection;
using System.Reflection;

namespace ReflectionTests

{
	[TestClass]
	public class ReflectionTestsClass
	{
		[TestMethod]
		public void CardConstruction()
		{

			var card = Activator.CreateInstance(typeof(Card), 1, "d") as Card;
			var card1 = new Card(1, "d");
			Assert.IsInstanceOfType(card, typeof(Card));

		}

		[TestMethod]
		public void CardProperties()
		{
			var card = Activator.CreateInstance(typeof(Card), 1, "d") as Card;
			var card1 = new Card(1, "d");
			Assert.AreEqual(card.Rank, card1.Rank);
			Assert.AreEqual(card.Suit, card1.Suit);

		}

		[TestMethod]
		public void CardMethods()
		{
			var card = Activator.CreateInstance(typeof(Card), 1, "d") as Card;
			var card1 = new Card(1, "d");
			Assert.AreEqual(card.ShowCard(), card1.ShowCard());

		}
	}
}
