using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Final
{
    internal abstract class Product
    {
        protected int Id;
        protected int idCounter = 1;
        protected string BrandName;
        public float Price;
        public bool isForSale { get; set; }


        public virtual void DisplayElement()
        { 
            
        }
    }
}
