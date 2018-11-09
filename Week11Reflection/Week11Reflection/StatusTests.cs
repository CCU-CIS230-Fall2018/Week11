using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using Week11Excercise;

namespace Week11Reflection
{
    [TestClass]
    public class StatusTests
    {
        [TestMethod]
        public void StatusBuildTest()
        {
            var myStatus = new Status();

            var statusReflection = Activator.CreateInstance(typeof(Status)) as Status;

            Assert.IsNotNull(myStatus);
            Assert.IsNotNull(statusReflection);
            Assert.IsInstanceOfType(statusReflection, typeof(Status));
        }

        [TestMethod]
        public void StatusPropertyTest()
        {
            var myStatus = new Status();
            var statusReflection = Activator.CreateInstance(typeof(Status)) as Status;

            statusReflection.GetType().GetProperty("RankingStatus").SetValue(statusReflection, "High");
            statusReflection.GetType().GetProperty("UpwardGrowth").SetValue(statusReflection, "Impossible");
            Assert.AreEqual("High", statusReflection.GetType().GetProperty("RankingStatus").GetValue(statusReflection, null));
            Assert.AreEqual("Impossible", statusReflection.GetType().GetProperty("UpwardGrowth").GetValue(statusReflection, null));


            Assert.IsTrue(statusReflection.GetType().GetProperty("RankingStatus").CanRead);
            Assert.IsTrue(statusReflection.GetType().GetProperty("RankingStatus").CanWrite);

            Assert.IsTrue(statusReflection.GetType().GetProperty("UpwardGrowth").CanRead);
            Assert.IsTrue(statusReflection.GetType().GetProperty("UpwardGrowth").CanWrite);
        }

        [TestMethod]
        public void StatusMethodTest()
        {
            var statusReflection = Activator.CreateInstance(typeof(Status)) as Status;

            var statusMethod = statusReflection.GetType().GetMethod("SetRanking");
            statusMethod.Invoke(statusReflection, null);

            Assert.AreEqual("High", statusReflection.GetType().GetProperty("RankingStatus").GetValue(statusReflection, null));
            Assert.AreEqual("Impossible", statusReflection.GetType().GetProperty("UpwardGrowth").GetValue(statusReflection, null));

        }
    }
}