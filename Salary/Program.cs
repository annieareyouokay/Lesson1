using System;
using Utilities;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] database = new int[7, 12];
            GenerateSalaryDatabase(ref database);
            Console.WriteLine("Введите порядковый номер месяца 1 - 12");
            var month = Auxiliary.GetNumber();
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Порядковый номер месяца должен быть в диапазоне от 1 - 12");
                return;
            }

            Console.WriteLine("Общая зарпалата сотрудников за {0} составила {1}", ((Auxiliary.Month)month).ToString().ToLower(), GetSalarySumForMonth(month, ref database));
        }

        private static void GenerateSalaryDatabase(ref int[,] database) {
            Random random = new Random();
            for (int i = 0; i < database.GetLength(0); i++)
            {
                for (int j = 0; j < database.GetLength(1); j++)
                {
                    database[i, j] = random.Next(10000, 100000);
                }
            }
        }

        private static int GetSalarySumForMonth(int month, ref readonly int[,] salaryDatabase) {

            int result = 0;
            for (int i = 0; i < salaryDatabase.GetLength(0); i++)
            {
                result += salaryDatabase[i, month];
            }

            return result;
        }
    }
}
