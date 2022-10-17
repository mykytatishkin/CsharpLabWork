using Exam.ExceptionBase;
using Exam.Shop.ProductBase;
using System;
using System.Linq;

namespace Exam.Shop
{
    public class ShopF1 : Shop
    {
        private ProductStore ProductStore;

        public event ProductStoreLowEventHandler ProductLow 
        {
            add { ProductStore.ProductStoreLow += value; }
            remove { ProductStore.ProductStoreLow -= value; }
        }

        public ShopF1() : base(1, "F1")
        {
            ProductStore = new ProductStore();            
        }

        #region Product
        public void AddProduct(ProductGadget product)
        {         
            ProductStore.AddProduct(product);
        }
        public void AddProduct(ProductComputer product)
        {
            // добавление нового товара
            ProductStore.AddProduct(product);            
        }

        public void EditProduct(int Id, string Name = null, string Motherboard = null, int ? Weigth = null)
        {
            var item = ProductStore.FindProduct(Id);

            if (item is ProductComputer c)
            {
                if(!string.IsNullOrEmpty(Motherboard))
                    c.Motherboard = Motherboard;

                if (!string.IsNullOrEmpty(Name))
                    c.Name = Name;

                c.Change = DateTime.Now;

                Console.WriteLine($"Computer: {item} is changed");
            }
            else if (item is ProductGadget g)
            {
                if(Weigth != null)
                    g.Weigth = Weigth.Value;

                if (!string.IsNullOrEmpty(Name))
                    g.Name = Name;

                g.Change = DateTime.Now;

                Console.WriteLine($"Gadget: {item} is changed");
            }

        
        }
        #endregion

        public void AddOrder(ProductGadget product/*, Cusomer cusomer*/)
        {
            try
            {
                // выдача исключения BalanceLowException
                // throw new BalanceLowException("Не хватает средств для покупки");
                ProductStore.AddOrder(product);
            }
            catch (BalanceLowException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        public void AddOrder(ProductComputer product)
        {
            // вызов события - мало товара Asus
            ProductStore.ProductStoreLowEvent("Asus");
        }

        public void ShowProduct() 
        {
            foreach (var item in ProductStore.ProductsItems)
            {
                if (item is ProductComputer)
                {
                    Console.WriteLine($"Computer: {item}");
                }
                else if (item is ProductGadget)
                {
                    Console.WriteLine($"Gadget: {item}");
                }
            }
        }

    }
}
