using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Final
{
    internal class Shovels: Product
    {

        private string Size { get; }
        private string Material { get; }
        public Shovels(string brandName, int price, string size, string material)
        {
            Id = idCounter++;
            BrandName = brandName;
            Price = price;
            if(!Enum.IsDefined(typeof(shovelSize), size))
            {
                throw new ArgumentException("Wrong input)");
            }
            Size = size;
            if (!Enum.IsDefined(typeof(shovelMaterial), material))
            {
                throw new ArgumentException("Wrong input)");
            }
            Material = material;
            isForSale = true;

        }
        enum shovelSize
        {
            Small,
            Medium,
            Large,
        }


        enum shovelMaterial
        {
            Aluminum,
            Steel,
        }

    }

 
}
