using Exam.Customer;
using Exam.Shop.ProductBase;

namespace Exam.Shop.Interface
{
    public interface IAddProduct<T>
    {
        void AddProduct(T product);
        void BuyProduct(Order order, Product product);
    }
}