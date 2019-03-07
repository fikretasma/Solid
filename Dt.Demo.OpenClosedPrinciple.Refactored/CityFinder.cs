using System;

namespace Dt.Demo.OpenClosedPrinciple.Refactored
{
    public class CityFinder
    {
        
        public string _countryName { get; set; }
        private IPlateCodeVerifier _plateCodeVerifier;
        public CityFinder(string countryName) {
            _countryName = countryName;
            if (_countryName == "TR")
            {
                _plateCodeVerifier = new TurkeyPlateCodeVerifier();
            }
            else if (_countryName == "USA") {
                _plateCodeVerifier = new UsaPlateCodeVerifier();
            }
        }

        public string GetCityNameByPlateCode(string plateCode)
        {

            if (!_plateCodeVerifier.IsValid(plateCode))
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