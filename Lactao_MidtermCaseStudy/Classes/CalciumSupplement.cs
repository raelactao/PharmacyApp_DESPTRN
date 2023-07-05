using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lactao_MidtermCaseStudy.Classes
{
    internal class CalciumSupplement : Product
    {
        private string name;
        private string type;
        private string unit;
        private decimal price;

        public CalciumSupplement()
        {
            this.name = "Calcium Supplement";
            this.type = "Mineral";
            this.unit = "500 mg";
            this.price = 8.25M;
        }

        public override string Name => name;

        public override string Type => type;

        public override string Unit => unit;

        public override decimal Price => price;
    }
}
