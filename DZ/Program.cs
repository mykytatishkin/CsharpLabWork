using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void BackPackTool(string[] someItems);
delegate void NotionHandler(string message);

namespace ConsoleApp1
{
    internal class Program
    {
        public event NotionHandler Notification;

        static void Main(string[] args)
        {
            /*
            Задание 
                Создайте класс рюкзак. Характеристики рюкзака:
                ■ Цвет рюкзака;
                ■ Фирма производитель;
                ■ Ткань рюкзака;
                ■ Вес рюкзака;
                ■ Объём рюкзака;
                ■ Содержимое рюкзака (список объектов, у каждого объекта кроме названия нужно учитывать занимаемый объём).
                
                Создайте методы для заполнения характеристик.
                Создайте событие для добавления объекта в рюкзак.
                Реализуйте анонимный метод в качестве обработчика
                события добавления объекта. Если при попытке добавления может быть превышен объём рюкзака, нужно
                генерировать исключение.
         */
           

            BackPack backpack = new BackPack();

            BackPackTool bat = delegate (string[] sitems)
            {
                for (int i = 0; i < backpack.litras; i++)
                    backpack.items[i] = sitems[i];

                foreach (var item in backpack.items)
                    Console.WriteLine(item);
            };

            string[] listOfItems = { "Termos", "Laptop", "Charger" };

            bat(listOfItems);

            
        }
    }
}
