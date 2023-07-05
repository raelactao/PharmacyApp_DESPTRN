using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lactao_MidtermCaseStudy.Classes
{
    public class Factory
    {
        public static Product Add(string vitamin)
        {
            switch (vitamin)
            {
                case "vitaminC":
                    return new VitaminC();

                case "vitaminE":
                    return new VitaminE();

                case "multivitamins":
                    return new Multivitamins();

                case "iron":
                    return new IronSupplement();

                case "calcium":
                    return new CalciumSupplement();

                case "magnesium":
                    return new MagnesiumSupplement();

                default:
                    throw new Exception("Invalid Product");
            }
        }
    }
}
