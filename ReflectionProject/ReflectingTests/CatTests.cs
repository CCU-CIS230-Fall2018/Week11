using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reflections;

namespace ReflectingTests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void CatConstructionTest()
        {
            var cat = new Cat();

            var reflectCat = Activator.CreateInstance(typeof(Cat)) as Cat;

            Assert.IsNotNull(cat);
            Assert.IsNotNull(reflectCat);
            Assert.IsInstanceOfType(reflectCat, typeof(Cat));

        }

        [TestMethod]
        public void CatPropertyTest()
        {
            var dog = new Cat();

            var reflectCat = Activator.CreateInstance(typeof(Cat)) as Cat;

            reflectCat.GetType().GetProperty("Lives").SetValue(reflectCat, 3);
            reflectCat.GetType().GetProperty("Breed").SetValue(reflectCat, "Stray");
            Assert.AreEqual(3, reflectCat.GetType().GetProperty("Lives").GetValue(reflectCat, null));
            Assert.AreEqual("Stray", reflectCat.GetType().GetProperty("Breed").GetValue(reflectCat, null));

            Assert.IsTrue(reflectCat.GetType().GetProperty("Lives").CanRead);
            Assert.IsTrue(reflectCat.GetType().GetProperty("Lives").CanWrite);

            Assert.IsTrue(reflectCat.GetType().GetProperty("Breed").CanRead);
            Assert.IsTrue(reflectCat.GetType().GetProperty("Breed").CanWrite);
        }

        [TestMethod]
        public void CatMethodTest()
        {
            var cat = new Cat();

            var reflectCat = cat.GetType().GetMethod("LoseLife");


            int lives = (int)reflectCat.Invoke(cat, new object[] { 3 });

            Assert.AreEqual(2, lives);

        }
    }

}

