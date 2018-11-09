using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void BirthdayCelebration()
        {
            Console.WriteLine("Happy Birthday!!!");
        }
    }
}
