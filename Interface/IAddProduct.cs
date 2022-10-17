using Exam.Shop.ProductBase;

namespace Exam.Shop.Interface
{
    public interface IAddProduct<T>
    {
        void AddProduct(T product);
    }
}