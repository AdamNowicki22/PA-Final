using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Final
{
    internal class Milk:Product
    {
        DateTime ExpirationDate { get; }
        DateTime currentTime = DateTime.Now;
        public Milk(string brandName, float price, DateTime expirationDate)        
        {
            Id = idCounter++;
            BrandName = brandName;
            Price = price;
            ExpirationDate = expirationDate;
            isForSale = currentTime <= ExpirationDate ? true : false;
        }

        public void CheckIfMilkIsForSale()
        {
            isForSale = currentTime<=ExpirationDate? true: false;
        }
        public override void DisplayElement()
        {
            Console.WriteLine($"Milk brand: {BrandName}, Price: {Price}");
        }

    }
}
