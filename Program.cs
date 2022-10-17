using Exam.ExceptionBase;
using Exam.Shop;
using Exam.Shop.ProductBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Создать интернет-магазин, который имеет следующую структуру

            Интерфейсы: 
            - добавить товар (IAddProduct<T>)
            - изменить товар (IEditProduct<T>)
            - удалить товар (IDeleteProduct<T>)
            - найти товар (IFindProduct<T>)
            - показать все товары (IShowProduct<T>)
            - купить товар (IBuyProduct<T>)

            [Product]
            Базовый класс товар (Product)
            - ИД: Id (int)
            - Название: Name (string) 
            - Описание: Desc (string) 
            - Цена: Price (decimal)
            - Дата создания: Create (datetime)
            - Дата изменения: Change (datetime)

            Конкретный класс товар-компьютеры (ProductComputer)
            - Материнской плата
            - Тип и название CPU (string) 
            - Тип и название DDR (string) 
            - Тип и название SSD (string) 

            Конкретный класс товар-гаджеты (ProductGadget)
            - смартфон
            - планшет

            Базовый класс-список склада товаров для компьтеров (ProductComputerStore)
            - Остаток товара (int)

            [Customer]
            Базовый класс клиент (Customer)
            - ИД: Id (int)
            - Имя: FName (string) 
            - Фамилия: LName (string) 
            - Телефон: Phone (string)
            - Баланс: Balance (decimal)
            - Дата создания: Create (datetime)
            - Дата изменения: Change (datetime)

            Конкретный класс клиент (CustomerF1)
            Базовый класс клиент-менеджер (CustomerManagerF1)

            [Order]
            Конкретный класс заказ (Order)
            - ИД: Id (int)
            - Товар: Product (Product) 
            - Клиент: Customer (Customer) 
            - Сумма заказа: OrderSum (decimal)
            - Дата создания: Create (datetime)

            [Shop]
            Базовый класс магазин (Shop)
            - ИД: Id (int)
            - Название: Name (string) 
            - Описание: Desc (string) 

            Конкретный класс магазин-F1 (ShopF1)
            - Список товаров (ProductStore) 
            - Список заказов (Orders)

            Задачи
            1. Реализуйте все интерфейсы в классах CustomerManager, ProductComputerStore, ProductGadgetStore
            2. При добавлении нового товара в заказ, проверять достаточный баланс у клиента, в случае недостатка - выдавать исключение (BalanceLowException)
            3. При новом заказе и остатке продукта (меньше 3 шт.), выдавать уведомление об окончании товара
            */

            
            var s = new ShopF1();
            
            s.ProductLow += Products_ProductLow;
            s.AddProduct(new ProductComputer() { Id = 1, Name = "F1", DDR = "16 GB", CPU = "Intel CORE i5", Motherboard = "Asus", SSD = "Kingstone" , Create = DateTime.Now, Change = DateTime.Now });
            s.AddProduct(new ProductGadget() { Id = 2, Name = "Samsung", CPU = "Samsung CPU", DDR = "4 GB", Weigth = 100, Create = DateTime.Now, Change = DateTime.Now });

            s.EditProduct(2, Name:"Samsung Galaxy", Weigth:150);

            s.ShowProduct();

            Console.ReadLine();
        }

        private static void Products_ProductLow(string Name)
        {
            Console.WriteLine($"Продукт {Name} заканчивается");
        }
    }
}
