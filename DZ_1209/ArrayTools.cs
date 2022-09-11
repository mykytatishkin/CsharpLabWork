using System;
namespace DZ_1209
{
	public class ArrayTools
    {

		public void evenOutput(decimal[] array)
		{
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write("\tEVEN: ");
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine("\nEnd of EVEN nums");
		}
		public void oddOutput(decimal[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write("\tODD: ");
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine("\nEnd of ODD nums");
        }
		public void primeOutput(decimal[] array)
        {
            int j, p;

            for(int i = 0; i < array.Length; i++)
            {
                j = 2;
                p = 1;
                while(j < array[i])
                {
                    if (array[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if(p == 1)
                {
                    Console.Write("\tPRIME: ");
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine("\nEnd of PRIME nums");
        }
		public void fibonachiOutput(decimal[] array)
        {
            bool resultFibonachi = true;

            int urNum = array.Length;
            // Console.Write("Enter num: "); urNum = int.Parse(Console.ReadLine());

            int fibonachiElement = 0;
            int fibonachiElementFirst = 0;
            int fibonachiElementSecond = 1;


            while (resultFibonachi)
            {

                fibonachiElement = fibonachiElementFirst + fibonachiElementSecond;
                fibonachiElementFirst = fibonachiElementSecond;
                fibonachiElementSecond = fibonachiElement;
                Console.WriteLine(fibonachiElement);

                if (urNum > fibonachiElement)
                {
                    resultFibonachi = false;
                }
            }
            Console.WriteLine("\nFIBONACHI: {0}", resultFibonachi);
        }
	}
}

