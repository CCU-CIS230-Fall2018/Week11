using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public int AgeInDogYears(int age)
        {
            int dogAge = age * 7;
            return dogAge;
        }
    }
}
