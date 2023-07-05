using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lactao_MidtermCaseStudy.Classes
{
    public class MagnesiumSupplement : Product
    {
        private string name;
        private string type;
        private string unit;
        private decimal price;

        public MagnesiumSupplement()
        {
            this.name = "Magnesium Supplement";
            this.type = "Mineral";
            this.unit = "1000 mg";
            this.price = 9.50M;
        }

        public override string Name => name;

        public override string Type => type;

        public override string Unit => unit;

        public override decimal Price => price;
    }

}
