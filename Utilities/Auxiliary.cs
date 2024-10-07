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
            bool firstIteration = true;
            foreach (var item in numbersArray)
            {
                Console.Write((firstIteration ? "" : ", ") + item.ToString());
                firstIteration = false;
            }
            Console.Write("\n");
        }

        public static int[] GenerateNumbersArray(int size, int min, int max)
        {
            int[] newArray = new int[size];
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                newArray[i] = random.Next(min, max);
            }

            return newArray;
        }
    }
}
