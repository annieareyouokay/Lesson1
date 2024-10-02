namespace CopyingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var array2 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }

            PrintArray("Array1: ", array1);
            PrintArray("Array2: ", array2);

            void PrintArray(string message, int[] array)
            {
                Console.Write(message);
                for (int i = 0; i < array.Length; i++)
                {

                    Console.Write(array[i].ToString() + (i + 1 >= array.Length ? "" : ", "));
                }
                Console.Write(";\n");
            }
        }
    }
}
