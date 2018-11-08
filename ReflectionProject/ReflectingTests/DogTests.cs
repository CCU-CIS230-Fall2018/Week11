using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reflections;

namespace ReflectingTests
{
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        public void DogConstructionTest()
        {
            var dog = new Dog();

            var reflectDog = Activator.CreateInstance(typeof(Dog)) as Dog;

            Assert.IsNotNull(dog);
            Assert.IsNotNull(reflectDog);
            Assert.IsInstanceOfType(reflectDog, typeof(Dog));

        }

        [TestMethod]
        public void DogPropertyTest()
        {
            var dog = new Dog();

            var reflectDog = Activator.CreateInstance(typeof(Dog)) as Dog;

            reflectDog.GetType().GetProperty("Age").SetValue(reflectDog, 4);
            reflectDog.GetType().GetProperty("Name").SetValue(reflectDog, "Bo");
            Assert.AreEqual(4, reflectDog.GetType().GetProperty("Age").GetValue(reflectDog, null));
            Assert.AreEqual("Bo", reflectDog.GetType().GetProperty("Name").GetValue(reflectDog, null));

            Assert.IsTrue(reflectDog.GetType().GetProperty("Age").CanRead);
            Assert.IsTrue(reflectDog.GetType().GetProperty("Age").CanWrite);

            Assert.IsTrue(reflectDog.GetType().GetProperty("Name").CanRead);
            Assert.IsTrue(reflectDog.GetType().GetProperty("Name").CanWrite);
        }

        [TestMethod]
        public void DogMethodTest()
        {
            var dog = new Dog();

            var reflectDog = dog.GetType().GetMethod("AgeInDogYears");


            int age = (int)reflectDog.Invoke(dog, new object[] { 3 });

            Assert.AreEqual(21, age);

        }
    }

}
