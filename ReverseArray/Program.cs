using Utilities;

namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers, "Reversed array: ");

            int[] GenerateNumbers(int size = 10)
            {
                int[] newArray = new int[size];
                var random = new Random();
                for (var i = 0; i < size; i++)
                {
                    newArray[i] = random.Next(1 ,100);
                }

                return newArray;
            }

            void Reverse(int[] arrayForReverse)
            {
                int tmp, mid;

                mid = arrayForReverse.Length / 2;

                for (var i = 0; i < mid; i++)
                {
                    tmp = arrayForReverse[i];
                    arrayForReverse[i] = arrayForReverse[^(i+1)];
                    arrayForReverse[^(i + 1)] = tmp;
                }
            }

            void PrintNumbers(int[] numbersArray, string message)
            {
                Console.Write(message);
                Auxiliary.PrintArray(numbersArray);
            }
        }
    }
}
