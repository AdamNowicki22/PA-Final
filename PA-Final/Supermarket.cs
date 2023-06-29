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

        public void CheckMilkStockExpiration()
        {
            foreach (Milk milk in ProductsInStore) 
            {
                milk.ValidateIfMilkIsForSale();
            }
        }
        public void PrintStockForSale()
        {

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
            CheckMilkStockExpiration();
            foreach (Milk milk in ProductsInStore)
            {
                if (!milk.isForSale)
                {
                    ProductsInStore.Remove(milk);                
                }
            }
        }

        private float GetValueOfAllItemsForSale()
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
        public void AddProductToStore(Product product)
        {
            ProductsInStore.Add(product);

        }
        

    }
}
