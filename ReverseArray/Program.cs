namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            PrintNumbers(ref numbers, "Original array: ");
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

            void Reverse(ref int[] numbers)
            {
                int tmp, mid, count;

                mid = numbers.Length / 2;
                count = numbers.Length;
                for (int i = 0; i < mid; i++)
                {
                    tmp = numbers[i];
                    numbers[i] = numbers[^(i+1)];
                    numbers[^(i + 1)] = tmp;
                }
            }

            void PrintNumbers(ref readonly int[] numbers, string message = "")
            {
                Console.Write(message);
                foreach (var item in numbers)
                {
                    
                    Console.Write(item + (numbers.Last<int>() == item ? "\n" : ", "));
                }
            }
        }
    }
}
