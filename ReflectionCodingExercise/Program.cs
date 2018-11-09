using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // It is really slow, but it works. 
            Reflection.FirstName = "Don"; 
            Reflection.LastName = "Juan"; 
            Reflection.Age = 35; 
            Reflection.ID = 5555; 
            Reflection.Write(); 
        }
    }
}
