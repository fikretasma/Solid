using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt.Demo.InterfaceSegregationPrinciple.Refactored
{
    public interface IBook:ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
