using Exam.Shop.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Shop.ProductBase
{
    public class ProductComputerStore : ProductStore<ProductComputer>, IAddProduct<ProductComputer>
    {
        public ProductComputerStore()
        {
            //Add(new ProductComputer() { Id = 1, Name = "F1", Motherboard = "Asus", CPU = "Intel", DDR = "Samsung", SSD = "Kingstone"  });
            //Add(new ProductComputer() { Id = 1, Name = "F1", Motherboard = "Asus", CPU = "Intel", DDR = "Samsung", SSD = "Kingstone"  });
            //Add(new ProductComputer() { Id = 1, Name = "F1", Motherboard = "Asus", CPU = "Intel", DDR = "Samsung", SSD = "Kingstone"  });
        }
        public void AddProduct(ProductComputer product)
        {
            Add(product);

            //var t = this.FirstOrDefault(x => x.Name == "Asus");

            StoreCount++;
        }
    }
}
