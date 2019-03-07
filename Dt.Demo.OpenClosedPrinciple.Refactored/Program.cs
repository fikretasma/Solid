using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.OpenClosedPrinciple.Refactored
{
    class Program
    {
        static void Main(string[] args)
        { 
            var cityFinder = new CityFinder("USA");
            var cityName = cityFinder.GetCityNameByPlateCode("34");
            Console.WriteLine(cityName);
            Console.ReadLine();
        }
    }
}
