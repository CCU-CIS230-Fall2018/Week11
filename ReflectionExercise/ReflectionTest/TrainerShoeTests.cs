using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionExercise;
using System.Reflection;

namespace ReflectionTest
{
    [TestClass]
    public class TrainerShoeTests
    {
        [TestMethod]
        public void TrainerShoeReflection()
        {
            var trainerKicks = Activator.CreateInstance(typeof(TrainerShoe),"Brooks Ghost",300,false) as TrainerShoe;
            var trainersReflected = new TrainerShoe("Brooks Ghost", 300, false);

            Assert.AreEqual(trainerKicks.Model, trainersReflected.Model);
            Assert.AreEqual(trainerKicks.Mileage, trainersReflected.Mileage);
            Assert.AreEqual(trainerKicks.SpentTicker, trainersReflected.SpentTicker);
            Assert.IsInstanceOfType(trainerKicks, typeof(TrainerShoe));
            Assert.AreEqual(trainerKicks.ShoeTrainableCheck(), trainersReflected.ShoeTrainableCheck());
        }
    }
}
