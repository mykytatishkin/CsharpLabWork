using Exam.Customer;
using Exam.Shop.ProductBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Interface
{
    public interface IEditProduct<T>
    {
        void BuyProduct(Order order, Product product);
        void EditProduct(T product, int ID,
            string Name, decimal Amount, string Category,
            DateTime Created);
    }
}
