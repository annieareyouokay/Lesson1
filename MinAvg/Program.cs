namespace MinAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 456, 657, 2, 456, 322, 87, 32, 55 };
            Console.WriteLine("Min is: " + MinValue(array));
            Console.WriteLine("Average is: " + AveragValue(array));
        }
        static int MinValue(int[] array)
        {
            int min = array[0];
            foreach (var num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        static int AveragValue(int[] array)
        {
            int sum = 0;
            foreach (var num in array)
            {
                sum += num;
            }

            return sum / array.Length;
        }
    }
}
