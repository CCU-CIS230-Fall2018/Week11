using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is what the tests output:");

            Person person = (Person)Activator.CreateInstance(typeof(Person));
            person.FirstName = "Sam";
            person.LastName = "Smith";
            Type type = typeof(Person);
            Type classType = person.GetType();
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("Person is in the "+type.Namespace+" name space.");
            Console.WriteLine("Is person a constucted class: " + type.IsClass);
            Console.WriteLine("The list of properties in person are: ");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
            Console.WriteLine("First name of person: "+person.FirstName);
            Console.WriteLine("Last name of person: " + person.LastName);

            object personInstance = Activator.CreateInstance(type);
            Console.WriteLine("Invoking person method:");
            MethodInfo personMethod = type.GetMethod("BirthdayCelebration");
            personMethod.Invoke(personInstance,null);

            Console.WriteLine("");
            Company company = (Company)Activator.CreateInstance(typeof(Company));
            company.CompanyTitle = "Walmart";
            company.StockTickerSymbol = "WMT";
            Type companyType = typeof(Company);
            Type companyClassType = company.GetType();
            PropertyInfo[] companyProperties = companyType.GetProperties();
            Console.WriteLine("Company is in the " + companyType.Namespace + " name space.");
            Console.WriteLine("Is company a constucted class: " + companyType.IsClass);
            Console.WriteLine("The list of properties in person are: ");
            foreach (PropertyInfo property in companyProperties)
            {
                Console.WriteLine(property.Name);
            }
            Console.WriteLine("Company title: " + company.CompanyTitle);
            Console.WriteLine("Company stock symbol: " + company.StockTickerSymbol);

            object companyInstance = Activator.CreateInstance(companyType);
            Console.WriteLine("Invoking company method:");
            MethodInfo companyMethod = companyType.GetMethod("ContactInformation");
            companyMethod.Invoke(companyInstance, null);

        }
    }
}
