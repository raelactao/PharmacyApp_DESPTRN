using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lactao_MidtermCaseStudy.Classes
{
    public class IronSupplement : Product
    {
        private string name;
        private string type;
        private string unit;
        private decimal price;

        public IronSupplement()
        {
            this.name = "Iron Supplement";
            this.type = "Mineral";
            this.unit = "250 mg";
            this.price = 7.50M;
        }

        public override string Name => name;

        public override string Type => type;

        public override string Unit => unit;

        public override decimal Price => price;
    }

}
