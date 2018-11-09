using System;
using System.Reflection;
using Reflections;
using System.Linq;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReflectionsTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void PersonTestMethod()
        {
            Person person = (Person)Activator.CreateInstance(typeof(Person));
            person.FirstName = "Sam";
            person.LastName = "Smith";
            Type type = typeof(Person);
            Type classType = person.GetType();
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("Person is in the " + type.Namespace + " name space.");
            Console.WriteLine("Is person a constucted class: " + type.IsClass);
            Console.WriteLine("The list of properties in person are: ");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
            Console.WriteLine("First name of person: " + person.FirstName);
            Console.WriteLine("Last name of person: " + person.LastName);

            object personInstance = Activator.CreateInstance(type);
            Console.WriteLine("Invoking person method:");
            MethodInfo personMethod = type.GetMethod("BirthdayCelebration");
            personMethod.Invoke(personInstance, null);
        }
    }
}
