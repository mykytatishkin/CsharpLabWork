using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2109
{
    //public delegate void actionWithList(List<int> array);
    public class Southand
    {
        string pathPlus = @"/Users/mykytatishkin/Documents/GitHub/CsharpLabWork/Output/plus.txt";
        string pathMinus = @"/Users/mykytatishkin/Documents/GitHub/CsharpLabWork/Output/minus.txt";
        string path00 = @"/Users/mykytatishkin/Documents/GitHub/CsharpLabWork/Output/00.txt";
        string path00000 = @"/Users/mykytatishkin/Documents/GitHub/CsharpLabWork/Output/00000.txt";


        public void numsToFiles(List<int> array)
        {
            FileCheck(pathPlus);
            FileCheck(pathMinus);
            FileCheck(path00);
            FileCheck(path00000);

            for (int i = 0; i < array.Count; i++)
            { 
                conToFiles(array, pathPlus, array[i] >= 0);
                conToFiles(array, pathMinus, array[i] < 0);
                conToFiles(array, path00, array[i] >= 10);
                conToFiles(array, path00000, array[i] >= 10000);
            }
        }
        public void FileCheck(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("{0} file exist!", path);
            }
            else
            {
                File.Create(path);
                Console.WriteLine("{0} file created!", path);
            }
        }
        public void conToFiles(List<int> array, string path, bool condition)
        {
            List<string> tempArr = new List<string>();
            for(int i = 0; i < array.Count; i++)
            {
                if (condition)
                {
                    tempArr.Add(array[i].ToString());
                }
            }
            List<string> distinct = tempArr.Union(tempArr).ToList();

            File.WriteAllLines(path, distinct);
        }

    }

}

