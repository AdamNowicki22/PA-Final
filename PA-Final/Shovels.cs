using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Final
{
    internal class Shovels: Product, IDisplayElements
    {

        private string Size { get; }
        private string Material { get; }
        public Shovels(string brandName, float price, string size, string material)
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
            Big,
        }


        enum shovelMaterial
        {
            Aluminum,
            Steel,
        }

        public override void DisplayElement()
        {
            Console.WriteLine($"Shovel brand: {BrandName}, Size: {Size}, Material: {Material}, Price: {Price}");
        }

    }

 
}
