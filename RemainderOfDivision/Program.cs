using Utilities;

namespace RemainderOfDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Программа для вывода результатов операции деления***");
            var a = ParseInt("Введите делимое: ");
            var b = ParseInt("Введите делитель: ");

            if (b == 0)
            {
                Console.WriteLine("Делить на ноль нельзя!");
                return;
            }

            var quotient = a / b;
            var reminder = a % b;

            Console.WriteLine($"(при условии что a = {a} и b = {b}): {a}/{b} = {quotient} остаток {reminder}");

            int ParseInt(string message = "")
            {
                Console.WriteLine(message);
                return Auxiliary.GetNumber();
            }
        }
    }
}
