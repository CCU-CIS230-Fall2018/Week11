using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Week11Excercise
{
    public class Person
    {
        public string FirstName { get; set; }
        public string City { get; set; }

        public void SetNameAndCity()
        {
            this.FirstName = "Kevin";
            this.City = "Chicago";
        }
    }
}
