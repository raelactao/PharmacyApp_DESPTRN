using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lactao_MidtermCaseStudy.Classes
{
    abstract public class MineralSupplements
    {
        abstract public string Name { get; }
        abstract public string Type { get; }
        abstract public string Unit { get; }
        abstract public decimal Price { get; }
    }
}
