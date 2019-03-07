using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.OpenClosedPrinciple.Refactored
{
    interface IPlateCodeVerifier{
        bool IsValid(string plateCode);
    }
}
