using Utilities;

namespace MonthDays
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 12: ");
            var number = Auxiliary.GetNumber();
            if (number > 12 || number < 1)
            {
                Console.WriteLine("Число находится вне диапазона 1 - 12.");
                return;
            }

            Console.WriteLine((Auxiliary.Month)number);
        }
    }

}
