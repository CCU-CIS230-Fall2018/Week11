using System;
using System.Reflection;
using Reflections;
using System.Linq;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReflectionsTest
{
    [TestClass]
    public class CompanyTest
    {
        [TestMethod]
        public void CompanyTestMethod()
        {
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