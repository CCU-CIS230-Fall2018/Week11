using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    public class Company
    {
        public string CompanyTitle { get; set; }
        
        public string StockTickerSymbol { get; set; }

        public void ContactInformation()
        {
            Console.WriteLine("You can email our company at mycompanyemail@hotmail.com or contact us by phone at 800-345-8243");
        }
    }
}
