using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.SolidPrinciples.Lsp.NotRefactored
{
    public class ListPrice : CalculatorItem
    {
        private decimal _discountedKeyTurnPrice = 11;
        private decimal _currencyRate = 3;
        public override decimal Calculate()
        {
            return _discountedKeyTurnPrice * _currencyRate;
        }
    }
}
