using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Final
{
    internal class Trucks: Product
    {
        private int NumberOfWheels { get; set; }
        private bool IsCheckedByMaintanace { get; set; }
        public Trucks(string brandName, int price, int numberOfWheels, bool isCheckedByMaintanace = false)
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
            isForSale = isCheckedByMaintanace?true:false;
        }
        public void MaintananceCheck()
        {
            IsCheckedByMaintanace = true;
            isForSale = true;
        }

    }
}
