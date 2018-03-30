using System;
using System.Collections.Generic;

namespace ForTest
{
    static class Functions
    {
        public static bool Check()
        {
            Console.Clear();
            Console.Write("\nInput the year in next format:\n" +
                "YYYY : ");
            string yearInput = Console.ReadLine();

            int year;

            while (!int.TryParse(yearInput, out year) || !(year >= 1 && year <= 9999))
            {
                Console.WriteLine("Wrong input, Year must be in interval (1, 9999), Try again");
                yearInput = Console.ReadLine();
            }

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("\n___________\n{0} is leap\n___________", year);
            }
            else
            {
                Console.WriteLine("\n___________\n{0} isn't leap\n___________", year);
            }


            return true;
        }
        public static bool Calc()
        {
            Console.Clear();
            Console.Write("\nInput the first Date in next format:\n" +
               "DD/MM/YYYY : ");
            string dateinp = Console.ReadLine();
            DateTime date1;
            while (!(DateTime.TryParse(dateinp, out date1)))
            {
                Console.WriteLine("  Unable to parse '{0}'.", dateinp);
                Console.Write("\nInput the first Date in next format:\n" +
               "DD/MM/YYYY : ");
                dateinp = Console.ReadLine();
            }
            Console.Write("Input the second Date in next format:\n" +
               "DD/MM/YYYY : ");

            dateinp = Console.ReadLine();
            DateTime date2;
            while (!(DateTime.TryParse(dateinp, out date2)))
            {
                Console.WriteLine("  Unable to parse '{0}'.", dateinp);
                Console.Write("Input the second Date in next format:\n" +
               "DD/MM/YYYY : ");
                dateinp = Console.ReadLine();
            }

            if (date1 > date2)
            {
                DateTime tmp = date1;
                date1 = date2;
                date2 = tmp;
            }


            double difdates = (date2 - date1).TotalDays;
            Console.WriteLine($"\n\n___________\nThe difference between dates is {difdates} day(s)\n___________");

            Serializing.SerializeIn(date1, date2);

            return true;
        }
        public static bool Day()
        {
            Console.Clear();
            Console.Write("\nInput the Date in next format:\n" +
               "DD/MM/YYYY : ");
            string dateinp = Console.ReadLine();
            DateTime date1;
            while (!(DateTime.TryParse(dateinp, out date1)))
            {
                Console.WriteLine("  Unable to parse '{0}'.", dateinp);
                Console.Write("\nInput the Date in next format:\n" +
               "DD/MM/YYYY : ");
                dateinp = Console.ReadLine();
            }
            Console.WriteLine("It's {0}", date1.DayOfWeek);
            return true;
        }
        public static bool Quit()
        {
            Console.Clear();
            Console.WriteLine("GOODBYE");
            return false;
        }
    }
}