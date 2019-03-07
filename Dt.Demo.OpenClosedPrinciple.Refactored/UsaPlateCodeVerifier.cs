using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.OpenClosedPrinciple.Refactored
{
    public class UsaPlateCodeVerifier : IPlateCodeVerifier
    {
        public bool IsValid(string plateCode)
        {
            if (plateCode.Length < 3)
                return false;

            return true;
        }
    }
}
