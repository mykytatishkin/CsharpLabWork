using System;
using System.Collections;
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
             * Создать массив типа ArrayList, наполните разными данными (int, string и тп.) и отсортируйте каждый тип с помощью пользовательского интерфейса IComparer
             * 
             * https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-6.0
             * 
             * https://docs.microsoft.com/en-us/dotnet/api/system.collections.icomparer?view=net-6.0
             */

            ArrayList myArr = new ArrayList();

            myArr.Add("Hello");
            myArr.Add("Generic");
            myArr.Add("!");
            PrintArr(myArr);

            string[] words = { "vu", "vgtu", "c#", ".net", "asp.net", ".net core"};
            PrintArr(words);

            Array.Sort(words);
            PrintArr(words);
        }

        public static void PrintArr(IEnumerable list)
        {
            foreach(var item in list)
                Console.WriteLine(item);

            Console.WriteLine();
        }
    }
}
