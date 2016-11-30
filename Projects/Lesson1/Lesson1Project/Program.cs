using System;

namespace Lesson1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, fill in the following data:");
            string name = GetInfo("Name");
            int age = ValidateNum(GetInfo("Age"));
            string place = GetInfo("Place of birth");
            string date = ValidateDate(GetInfo("Date of birth (format MM/dd/yyyy)"), age);

            Console.Write("\nThanks, " + name + "! \r\nYou are " + age + " y.o.(born at " + date + ") and live in " + place + ". \r\n\nPress any key to exit...");
            Console.ReadKey();
        }

        static string ValidateDate(string field, int age)
        {
            DateTime date;
            if (DateTime.TryParseExact(field, "MM/dd/yy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                int yearDiff = DateTime.Now.Year - date.Year;
                if (age != yearDiff) {
                    return ValidateDate(GetInfo("You are a little lier :) Try again"), age);
                } 
                return date.ToString("ddd, MMMM, dd in yyyy");
            }

            return ValidateDate(GetInfo("Not valid! Try again"), age);
        }

        static int ValidateNum(string field)
        {
            int num;
            if (int.TryParse(field, out num))
            {
                return num;
            }
            else
            {
                return ValidateNum(GetInfo("Not valid! Try again"));
            }
        }

        static string GetInfo(string field) {
            Console.Write(field + ": ");
            return Console.ReadLine();
        }
    }
}
