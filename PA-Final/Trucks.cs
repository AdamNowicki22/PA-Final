using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Final
{
    internal class Trucks: Product, IDisplayElements
    {
        private int NumberOfWheels { get; set; }
        private bool IsCheckedByMaintanance { get; set; }
        public Trucks(string brandName, float price, int numberOfWheels, bool isCheckedByMaintanance)
        {
            Id = idCounter++;
            BrandName = brandName;
            Price = price;
            NumberOfWheels = numberOfWheels;
            //if (isCheckedByMaintanace)
            //{
            //isForSale = true;
            //}
            //else
            //{
            //isForSale = false;
            //}
            IsCheckedByMaintanance = isCheckedByMaintanance;
            isForSale = isCheckedByMaintanance?true:false;
        }
        public void MaintananceCheck()
        {
            IsCheckedByMaintanance = true;
            isForSale = true;
        }

        public override void DisplayElement()
        {
            Console.WriteLine($"Truck brand: {BrandName}, Wheels: {NumberOfWheels} Price: {Price}");
        }

    }
}
