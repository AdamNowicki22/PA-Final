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
            foreach (var product in ProductsInStore)
                if (product is Milk milk)
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

            for (int i = ProductsInStore.Count -1; i>=0;i--)
                foreach (Product product in ProductsInStore)
                    if (product is Milk milk)
                {
                    if (!milk.isForSale)
                    {
                        ProductsInStore.RemoveAt(i);
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
