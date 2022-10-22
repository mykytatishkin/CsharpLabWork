using Exam.Interface;
using Exam.Shop.Interface;
using Exam.Shop.ProductBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Customer
{
    internal class CustomerOrder : BindingList<Order>, IDeleteProduct<Product>, IShowProduct<Order>
    {
        public void AddProduct(Order order, Product product)
        {
            this.AddProduct(order, product);
        }

        public void BuyProduct(Order order, Product product)
        {
            order.OrderSum = product.Price;
        }

        public void DeleteProduct(Product product)
        {
            this.DeleteProduct(product);
        }

        public void ShowProduct(Order order, int productID)
        {
            if (order.Id == productID)
            {
                Console.WriteLine("ID: {0};\nProduct: {1}\nAmount: {2}\nCustomer: {3}\nOrder Sum: {4}; Created: {5}", order.Id, order.Product, order.Customers, order.OrderSum, order.Create);
            }
        }
    }
}
