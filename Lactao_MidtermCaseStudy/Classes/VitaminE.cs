using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lactao_MidtermCaseStudy.Classes
{
    public class VitaminE : Product
    {
        private string name;
        private string type;
        private string unit;
        private decimal price;

        public VitaminE()
        {
            this.name = "Vitamin E";
            this.type = "Vitamin";
            this.unit = "500 mg";
            this.price = 12.75M;
        }

        public override string Name => name;

        public override string Type => type;

        public override string Unit => unit;

        public override decimal Price => price;
    }
}
