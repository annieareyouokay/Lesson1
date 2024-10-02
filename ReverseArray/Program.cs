namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(ref numbers);
            PrintNumbers(ref numbers, "Reversed array: ");

            int[] GenerateNumbers(int size = 10)
            {
                int[] newArray = new int[size];
                var random = new Random();
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = random.Next(1 ,100);
                }

                return newArray;
            }

            void Reverse(ref int[] arrayForReverse)
            {
                int tmp, mid, count;

                mid = arrayForReverse.Length / 2;
                count = arrayForReverse.Length;
                for (int i = 0; i < mid; i++)
                {
                    tmp = arrayForReverse[i];
                    arrayForReverse[i] = arrayForReverse[^(i+1)];
                    arrayForReverse[^(i + 1)] = tmp;
                }
            }

            void PrintNumbers(ref readonly int[] numbersArray, string message)
            {
                Console.Write(message);
                bool firstIteration = true;
                foreach (var item in numbersArray)
                {
                    Console.Write((firstIteration ? "" : ", ") + item.ToString());
                    firstIteration = false;
                }
                Console.Write("\n");
            }
        }
    }
}
