using Utilities;

namespace DaysInMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите порядковый номер месяца от 1 - 12: ");
            var month = Auxiliary.GetNumber();
            if (month > 12 || month < 1)
            {
                Console.WriteLine("Число находится вне диапазона 1 - 12.");
                return;

            }

            Console.WriteLine("Введите год: ");
            var year = Auxiliary.GetNumber();
            if (year < 0)
            {
                Console.WriteLine("Число не должно быть отрицательным");
                return;
            }

            Console.WriteLine(GetMonthDays(month, year));
        }

        private static int GetMonthDays(int month, int year)
        {
            if (month == 2 && (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)))
            {
                return 29;
            }

            return month == 2 ? 28 : 30 + (month > 6 ? month + 1 : month) % 2;
        }
    }
}