using Utilities;

namespace TwoCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость первого автомобиля, км/ч:");
            var v1 = Auxiliary.GetNumber();
            Console.WriteLine("Введите скорость второго автомобиля, км/ч:");
            var v2 = Auxiliary.GetNumber();

            if (v1 < v2)
            {
                Console.WriteLine("Скорость первой машины меньше, значит она никогда не догонить вторую.");
                Environment.Exit(0);
            }

            Console.WriteLine("Введите расстояние на которое первый автомобиль опередит второй, км");
            Console.WriteLine("Расстояние между двумя автомобилями спустя 30 минут сотавит {0} км", Auxiliary.GetNumber() + (v1 - v2)/2);
        }
    }
}
