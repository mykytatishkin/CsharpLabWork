using System;
using System.IO;

// TASK 1

namespace Lab2109
{
    public class ToFilesAdd
    {
        string path = @"/Users/mykytatishkin/Documents/GitHub/CsharpLabWork/Output/prime.txt";
        string path2= @"/Users/mykytatishkin/Documents/GitHub/CsharpLabWork/Output/fibonachi.txt";

        public void primeToFile(List<int> array)
        {
            Console.Write("\n\tPRIME stars; ");
            List<string> tempList = new List<string>(); 
            int isPrime = 0;
            int isntPrime = 0;

            int[] primeNums = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            if (File.Exists(path))
            {
                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < primeNums.Length; j++)
                    {
                        if (array[i] == primeNums[j])
                        {
                            //File.WriteAllText(path, array[i].ToString());
                            tempList.Add(array[i].ToString());
                            /*
                            using (StreamWriter sw = File.CreateText(path))
                            {
                                sw.WriteLine(array[i] + "\n");
                            }
                            */
                            isPrime++;
                        }
                        else
                        {
                            isntPrime++;
                        }

                    }
                }
            }
            else
            {
                File.Create(path);
            }

            File.WriteAllLines(path, tempList);
            Console.WriteLine("\nEnd of PRIME nums; \n\tIS PRIME: {0} \n\tISN`T PRIME: {1}", isPrime, isntPrime);
        }
        public void fibonachiToFile(List<int> list)
        {
            List<string> tempList = new List<string>();
            int isFib = 0;
            int isntFib = 0;

            if (File.Exists(path2))
            {
                int a = 0, b = 1, c = 0;
                Console.WriteLine("{0} {1}", a, b);
                for (int i = 2; i < list.Max(); i++)
                {
                    c = a + b;
                    Console.WriteLine(" {0}", c);
                    a = b;
                    b = c;

                    if (list[i] == c)
                    {
                        tempList.Add(c.ToString());
                        isFib++;
                    }
                    else
                    {
                        isntFib++;
                    }    
                }
            }
            else
            {
                File.Create(path2);
            }
            File.WriteAllLines(path2, tempList);
            Console.WriteLine("\nEnd of FIBONACCI nums; \n\tIS FIBONACCI: {0} \n\tISN`T FIBONACCI: {1}", isFib, isntFib);

        }
    }
}