using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Создать массив типа ArrayList, наполните разными данными (int, decimal, float и тп.) и отсортируйте каждый тип с помощью пользовательского интерфейса IComparer
             * 2. Создайте generic класс Очередь с приоритетами. Реализуйте стандартные методы и свойства для работы очереди с приоритетами. (пример https://en.wikipedia.org/wiki/Priority_queue)
             */

            ArrayList array1 = new ArrayList();

            int[] ranNum = new int[5];

            for(int i = 0; i < ranNum.Length; i++)
            {
                Random rnd = new Random();
                int val = rnd.Next(1, 100);
            }

            array1.AddRange(ranNum);
            
            array1.Add(Convert.ToString(1.43));
            array1.Add(Convert.ToString(3.14));

            array1.Add("Hello");
            array1.Add("Collections");
            array1.Add("And");
            array1.Add("Gerecics!");

            PrintList(array1);

            array1.Sort(new SortingComparer());

            PrintList(array1);
        }
        public static void PrintList(IEnumerable list)
        {
            foreach(var item in list)
                Console.Write(item + "\t");

            Console.WriteLine();
        }

        public class SortingComparer : IComparer
        {
            readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

            public int Compare(object x, object y)
            {
                int result = comparer.Compare(y, x);
                if (x is int && y is int)
                    return (int)x > (int)y ? 1 : (int)x < (int)y ? -1 : 0;

                return result;
            }
        }
    }
}
