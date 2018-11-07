using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week11_Reflection;
namespace ReflectionTests
// Each test class should use reflection to:
// Confirm that the class can be constructed
// Confirm that each property can be written and read(or just read if it is read-only)
// Confirm that each method can be invoked

{
	[TestClass]
	public class CardDeckTests
	{
		//var astronaut = Activator.CreateInstance(typeof(Astronaut), 22, "Apollo 11") as Astronaut;
		//var astronaut1 = new Astronaut(22, "Apollo 11");

		//Assert.IsInstanceOfType(astronaut, typeof(Astronaut));
		//      Assert.AreEqual(astronaut.Age, astronaut1.Age);
		//      Assert.AreEqual(astronaut.Mission, astronaut1.Mission);

		[TestMethod]
		public void CardDeckConstruction()
		{
			var deck = Activator.CreateInstance(typeof(CardDeck)) as CardDeck;
			var deck1 = new CardDeck();
			Assert.IsInstanceOfType(deck, typeof(CardDeck));
		}

		[TestMethod]
		public void CardDeckProperties()
		{
			var deck = Activator.CreateInstance(typeof(CardDeck)) as CardDeck;
			var deck1 = new CardDeck();

			Assert.AreEqual(deck.Deck[0].ShowCard(), deck1.Deck[0].ShowCard());
		}

		[TestMethod]
		public void CardDeckMethods()
		{
			var deck = Activator.CreateInstance(typeof(CardDeck)) as CardDeck;
			var deck1 = new CardDeck();
			Assert.AreEqual(deck.GetDeck()[0].ShowCard(), deck1.GetDeck()[0].ShowCard());
		}
	}
}
