using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Final
{
    internal class Supermarket
    {

        List<Product> ProductsInStore = new List<Product>();
        public Supermarket()
        {
            ProductsInStore = new List<Product>();
        }

        public void CheckMilkStock()
        {
            foreach (Milk milk in ProductsInStore) 
            {
                milk.CheckIfMilkIsForSale();
            }
        }
        public void PrintStockForSale()
        {
            CheckMilkStock();
            foreach (Product product in ProductsInStore)
            {
            if (product.isForSale)
                {
                    product.DisplayElement();
                }           
            }
        }
        public void RemoveSourMilk()
        {
            CheckMilkStock();
            foreach (Milk milk in ProductsInStore)
            {
                if (!milk.isForSale)
                {
                    ProductsInStore.Remove(milk);                
                }
            }
        }

        public float GetValueOfAllItemsForSale()
        {
            float totalValue = 0;
            foreach (Product product in ProductsInStore)
            {
                if (product.isForSale)
                {
                    totalValue += product.Price;
                }
            }
        
            return totalValue;
        }

        public bool CanIAffordEverything(float myMoney)
        {
            return GetValueOfAllItemsForSale()<= myMoney;
        }
        

    }
}
