using System;
using static System.Console;

namespace Home_2609
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder_Seach fs = new Folder_Seach("*.txt");

            fs.FileSearchInMainDirectory();
        }
    }
}