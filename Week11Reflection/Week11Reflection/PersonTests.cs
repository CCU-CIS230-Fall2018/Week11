using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using Week11Excercise;

namespace Week11Reflection
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void PersonBuildTest()
        {
            var myPerson = new Person();

            var personReflection = Activator.CreateInstance(typeof(Person)) as Person;

            Assert.IsNotNull(myPerson);
            Assert.IsNotNull(personReflection);
            Assert.IsInstanceOfType(personReflection, typeof(Person));
        }

        [TestMethod]
        public void PersonPropertyTest()
        {
            var myPerson = new Person();
            var personReflection = Activator.CreateInstance(typeof(Person)) as Person;

            personReflection.GetType().GetProperty("FirstName").SetValue(personReflection, "Kevin");
            personReflection.GetType().GetProperty("City").SetValue(personReflection, "Chicago");
            Assert.AreEqual("Kevin", personReflection.GetType().GetProperty("FirstName").GetValue(personReflection, null));
            Assert.AreEqual("Chicago", personReflection.GetType().GetProperty("City").GetValue(personReflection, null));


            Assert.IsTrue(personReflection.GetType().GetProperty("FirstName").CanRead);
            Assert.IsTrue(personReflection.GetType().GetProperty("FirstName").CanWrite);

            Assert.IsTrue(personReflection.GetType().GetProperty("City").CanRead);
            Assert.IsTrue(personReflection.GetType().GetProperty("City").CanWrite);
        }

        [TestMethod]
        public void PersonMethodTest()
        {
            var personReflection = Activator.CreateInstance(typeof(Person)) as Person;

            var personMethod = personReflection.GetType().GetMethod("SetNameAndCity");
            personMethod.Invoke(personReflection, null);

            Assert.AreEqual("Kevin", personReflection.GetType().GetProperty("FirstName").GetValue(personReflection, null));
            Assert.AreEqual("Chicago", personReflection.GetType().GetProperty("City").GetValue(personReflection, null));

        }
    }
}