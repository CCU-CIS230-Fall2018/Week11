using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionCodingExercise
{
    class Reflection
    {
        public static string FirstName;
        public static string LastName;
        public static int Age;
        public static int ID;

        public static void Write()
        {
            Type type = typeof(Reflection);
            FieldInfo[] Employee = type.GetFields();
            foreach (var emp in Employee)
            {
                string name = emp.Name;
                object temp = emp.GetValue(null); 
                if (temp is int) 
                {
                    int value = (int)temp;
                    Console.Write(name);
                    Console.Write(" (int) = ");
                    Console.WriteLine(value);
                }
                else if (temp is string) 
                {
                    string value = temp as string;
                    Console.Write(name);
                    Console.Write(" (string) = ");
                    Console.WriteLine(value);
                }
            }
        }
    }
}
