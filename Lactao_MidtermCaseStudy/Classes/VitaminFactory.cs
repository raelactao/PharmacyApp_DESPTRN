using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lactao_MidtermCaseStudy.Classes
{
    public class VitaminFactory
    {
        public static VitaminSupplements AddVitamin(string vitamin)
        {
            switch (vitamin)
            {
                case "vitaminC":
                    return new VitaminC();

                case "vitaminE":
                    return new VitaminE();

                case "multivitamins":
                    return new Multivitamins();

                default:
                    throw new Exception("Invalid Vitamin");
            }
        }
    }
}
