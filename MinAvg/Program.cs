namespace MinAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[]{ 23, 456, 657, 2, 456, 322, 87, 32, 55 };
            Console.WriteLine("Min is: " + MinValue(array));
            Console.WriteLine("Average is: " + AverageValue(array));

            int MinValue(int[] array)
            {
                var min = array[0];
                foreach (var num in array)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
            }

            double AverageValue(int[] array)
            {
                var sum = 0d;
                foreach (var num in array)
                {
                    sum += num;
                }

                return Math.Round(sum / array.Length, 2);
            }
        }
    }
}
