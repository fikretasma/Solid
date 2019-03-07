using System;

namespace Dt.Demo.OpenClosedPrinciple.NotRefactored
{
    public class CityFinder
    {
        private string _countryName { get; set; }
        public CityFinder(string countryName) {
            _countryName = countryName;
        }

        public string GetCityNameByPlateCode(string plateCode)
        {
            //Türkiye için plaka kodu 2 karakterden büyük olamaz.
            if (_countryName == "TR" && plateCode.Length > 2)
            {
                throw new InvalidOperationException($"Invalid PlateCode: {plateCode}");
            }
            else if (_countryName == "USA" && plateCode.Length < 3)
            {
                throw new InvalidOperationException($"Invalid PlateCode: {plateCode}");
            }

            switch (plateCode)
            {
                case "06":
                    return "Ankara";
                case "34":
                    return "İstanbul";
                case "35":
                    return "İzmir";
                default:
                    return "";
            }
        }
    }
}