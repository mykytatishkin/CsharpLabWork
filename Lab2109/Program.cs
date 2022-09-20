using System;
using System.Collections.Generic;
using static System.Console;

namespace Lab2109
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Random r = new Random();
            List<int> list = new List<int>();
            ToFilesAdd toFiles = new ToFilesAdd();

            for(int i = 0; i < 100000; i++)
            {
                int rInt = r.Next(0, 100);
                list.Add(rInt);
                Write(list[i] + " ");
            }

            list.Sort();

            toFiles.primeToFile(list);
            toFiles.fibonachiToFile(list);

            ConsoleReseting();
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            FIleWordSearch fws = new FIleWordSearch();
            
            fws.FileWordReplaceing("Lorem", "AAAAA");
            Console.WriteLine("Replacing finished");

            ConsoleReseting();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Southand s = new Southand();
            s.numsToFiles(list);

        }

        public static void ConsoleReseting()
        {
            // 10 sec -> 10000
            Thread.Sleep(100);
            Console.Clear();
            Console.ResetColor();
        }
    }
}