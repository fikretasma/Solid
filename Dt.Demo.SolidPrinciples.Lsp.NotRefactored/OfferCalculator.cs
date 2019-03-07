using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.SolidPrinciples.Lsp.NotRefactored
{
    public class OfferCalculator
    {
        public void Calculate(List<CalculatorItem> calculatorItemsList)
        {
            calculatorItemsList.ForEach(x => x.Calculate());
        }
    }
}
