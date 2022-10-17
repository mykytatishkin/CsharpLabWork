using Exam.Shop.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Exam.Shop.ProductBase
{
    public delegate void ProductStoreLowEventHandler(string Name);
    public class ProductStore : List<Product>, IAddProduct<Product>
    {
        //public List<Product> ProductsItems;
        //public List<Order> items;

        public event ProductStoreLowEventHandler ProductStoreLow = null;

        public void ProductStoreLowEvent(string Name)
        {
            if (ProductStoreLow != null)
            {
                ProductStoreLow.Invoke(Name); // вызываем метод Invoke на событии
            }
        }

        public void AddProduct(Product product) 
        {
            this.Add(product);
        }

        public bool AvailableCategory(string catagory) 
        {
            return this.Any(x => x.Category == catagory);
        }

        public Product FindProduct(int Id) 
        {
            return this.FirstOrDefault(x => x.Id == Id);
        }


    }
}
