using Exam.Interface;
using Exam.Shop.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.Shop.ProductBase
{
    public delegate void ProductStoreLowEventHandler(string Name);
    public class ProductStore : List<Product>, IAddProduct<Product>,
        IBuyProduct<Product>, IDeleteProduct<Product>,
        IEditProduct<Product>, IShowProduct<Product>
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

        public void BuyProduct(Product product)
        {
            
        }

        public void DeleteProduct(Product product)
        {

        }

        public void EditProduct(Product product, int ID, string Name, decimal Amount, string Category, DateTime Created)
        {
            product.Id = ID; product.Name = Name; product.Amount = Amount; product.Category = Category; product.Create = Created; product.Change = DateTime.Now;
        }

        public void ShowProduct(Product product,int productID)
        {
            if(product.Id == productID)
            {
                Console.WriteLine("ID: {0};\nName: {1}\nAmount: {2}\nCategory: {3}\nCreated: {4}; Changed: {5}", product.Id, product.Name, product.Amount, product.Category, product.Create, product.Change);
            }
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
