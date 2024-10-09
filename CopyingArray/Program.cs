using Utilities;

namespace CopyingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var array2 = new int[10];

            for (var i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
            Console.Write("Array1: ");
            Auxiliary.PrintArray(array1);
            Console.Write("Array2: ");
            Auxiliary.PrintArray(array2);
        }
    }
}
