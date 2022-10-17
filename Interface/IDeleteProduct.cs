using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Interface
{
    public interface IDeleteProduct<T>
    {
        void DeleteProduct(T product);
    }
}
