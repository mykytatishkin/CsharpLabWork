using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDateParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Создать регулярное выражение для извлечения даты, без учета знаков разделителя. 
             Вывести результат на отдельные части: дата, месяц, год
             */

            string date = @"(?<data>[1-3][0-9])[\.\/\-\s\\](?<month>[0-9]{2})[\.\/\-\s\\](?<year>[0-9]{4})\b";

            string BirthDate = "25/01/2005";

            var regDate = new Regex(date);

            if (regDate.IsMatch(BirthDate))
            {
                try
                {
                    int year;
                    int.TryParse(regDate.Match(BirthDate).Groups["year"].Value, out year);

                    int month;
                    int.TryParse(regDate.Match(BirthDate).Groups["month"].Value, out month);

                    int day;
                    int.TryParse(regDate.Match(BirthDate).Groups["day"].Value, out day);

                    DateTime dtBirth = new DateTime(year, month, day);

                    Console.WriteLine("BirthDate :" + dtBirth.ToString("dd-MM-yyy"));
                }

                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }
    }
}
}
