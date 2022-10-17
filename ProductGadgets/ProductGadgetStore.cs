using Exam.Shop.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Shop.ProductBase
{
    public class ProductGadgetStore : ProductStore<ProductGadget>, IAddProduct<ProductGadget>
    {        
        public void AddProduct(ProductGadget product)
        {
            Add(product);

            StoreCount++;
        }
    }
}
