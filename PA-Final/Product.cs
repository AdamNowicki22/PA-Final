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
        protected int Price;
        protected bool isForSale;


        public virtual void DisplayElement()
        { 
            
        }
    }
}
