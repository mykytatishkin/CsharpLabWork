using System.Collections.Generic;
using System.Linq;

namespace Exam.Shop.ProductBase
{
    public delegate void ProductStoreLowEventHandler(string Name);
    public class ProductStore 
    {
        public List<Product> ProductsItems;
        //public List<Order> items;


        public event ProductStoreLowEventHandler ProductStoreLow = null;

        public ProductStore()
        {
            ProductsItems = new List<Product>();
        }

        public void ProductStoreLowEvent(string Name)
        {
            if (ProductStoreLow != null)
            {
                ProductStoreLow.Invoke(Name); // вызываем метод Invoke на событии
            }
        }


        public void AddProduct(Product product) 
        {
            ProductsItems.Add(product);
        }


        public void AddOrder(Product product/*, Cusomer cusomer*/)
        {
            /*cusomer проверить баланс, в противном случае выдать ошибку BalanceLowException*/

            ProductsItems.Add(product);
        }

        public Product FindProduct(int Id) 
        {
            return ProductsItems.FirstOrDefault(x => x.Id == Id);
        }

        protected int StoreCount;
    }
}
