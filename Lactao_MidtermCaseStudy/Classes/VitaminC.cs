using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lactao_MidtermCaseStudy.Classes
{
    public class VitaminC : VitaminSupplements
    {
        private string name;
        private string type;
        private string unit;
        private decimal price;

        public VitaminC()
        {
            this.name = "Sodium ascorbate (Vitamin C)";
            this.type = "Vitamin";
            this.unit = "1000 IU";
            this.price = 15.00M;
        }
        public override string Name => name;

        public override string Type => type;

        public override string Unit => unit;

        public override decimal Price => price;

    }
}
