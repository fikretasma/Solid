using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.OpenClosedPrinciple.NotRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            var cityFinder = new CityFinder();
            var cityName = cityFinder.GetCityNameByPlateCode("34");
            Console.WriteLine(cityName);
            Console.ReadLine();
        }
    }
}
