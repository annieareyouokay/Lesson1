using System.Drawing;

namespace Utilities
{
    public class Auxiliary
    {

        public enum Month
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

        private Auxiliary() { }

        public static int GetNumber()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {

                Console.WriteLine("Введенный вами символ не является числом. Попробуйте ещё раз: ");
            }

            return number;
        }

        public static void PrintArray(int[] numbersArray)
        {
            Console.WriteLine(string.Join(", ", numbersArray));;
        }

        public static int[] GenerateNumbersArray(int size, int min, int max)
        {
            var newArray = new int[size];
            var random = new Random();
            for (var i = 0; i < size; i++)
            {
                newArray[i] = random.Next(min, max);
            }

            return newArray;
        }
    }
}
