using Utilities;

namespace MonthDays
{
    internal class Program
    {
        enum Month
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 12: ");
            var number = Auxiliary.GetNumber();
            if (number > 12 || number < 1)
            {
                Console.WriteLine("Число находится вне диапазона 1 - 12.");
                return;
            }

            Console.WriteLine((Month)number);
        }
    }

}
