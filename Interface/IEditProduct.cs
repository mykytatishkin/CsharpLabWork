using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Interface
{
    public interface IEditProduct<T>
    {
        void EditProduct(T product);
    }
}
