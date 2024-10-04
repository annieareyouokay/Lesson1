namespace Utilities
{
    public class Auxiliary
    {
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

        public static void PrintArray(ref readonly int[] numbersArray)
        {
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
