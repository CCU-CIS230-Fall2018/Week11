using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using ReflectionExercise;

namespace ReflectionTest
{
    [TestClass]
    public class RunnerTests
    {
        [TestMethod]
        public void RunnerReflection()
        {
            var runner = Activator.CreateInstance(typeof(Runner), 110, "Addidas") as Runner;
            var runnerReflected = new Runner(110, "Addidas");

            Assert.AreEqual(runner.Team, runnerReflected.Team);
            Assert.AreEqual(runner.Mileage, runnerReflected.Mileage);
            Assert.AreEqual(runner.DailyMileage(), runnerReflected.DailyMileage());
            Assert.IsInstanceOfType(runner, typeof(Runner));
            Assert.IsInstanceOfType(runnerReflected, typeof(Runner));
        }
    }
}
