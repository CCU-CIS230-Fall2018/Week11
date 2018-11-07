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
	public class PlayerTests
	{
		[TestMethod]
		public void PlayerConstruction()
		{
			var player = Activator.CreateInstance(typeof(Player),"Jamal") as Player;
			var player1 = new Player("Jamal");
			Assert.IsInstanceOfType(player, typeof(Player));

		}

		[TestMethod]
		public void PlayerProperties()
		{
			var player = Activator.CreateInstance(typeof(Player), "Jamal") as Player;
			var player1 = new Player("Jamal");
			Assert.AreEqual(player.Name,player1.Name);
		}

		[TestMethod]
		public void PlayerMethods()
		{
			var player = Activator.CreateInstance(typeof(Player), "Jamal") as Player;
			var player1 = new Player("Jamal");
			Card card = new Card(1, "h");
			player.AddCard(card);
			player1.AddCard(card);
			Assert.AreEqual(player.Hand[0], player1.Hand[0]);
		}
	}
}
