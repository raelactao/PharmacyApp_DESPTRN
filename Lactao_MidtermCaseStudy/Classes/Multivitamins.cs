using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lactao_MidtermCaseStudy.Classes
{
    public class Multivitamins : Product
    {
        private string name;
        private string type;
        private string unit;
        private decimal price;

        public Multivitamins()
        {
            this.name = "Multivitamins";
            this.type = "Vitamins";
            this.unit = "1 bottle";
            this.price = 60.00M;
        }
        public override string Name => name;

        public override string Type => type;

        public override string Unit => unit;

        public override decimal Price => price;
    }
}
