using System;
using Utilities;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var database = new int[7, 12];
            GenerateSalaryDatabase(database);
            Console.WriteLine("Введите порядковый номер месяца 1 - 12");
            var month = Auxiliary.GetNumber();
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Порядковый номер месяца должен быть в диапазоне от 1 - 12");
                return;
            }

            Console.WriteLine("Общая зарпалата сотрудников за {0} составила {1}", ((Auxiliary.Month)month).ToString().ToLower(), GetSalarySumForMonth(month, database));
        }

        private static void GenerateSalaryDatabase(int[,] database) {
            var random = new Random();
            for (var i = 0; i < database.GetLength(0); i++)
            {
                for (var j = 0; j < database.GetLength(1); j++)
                {
                    database[i, j] = random.Next(10000, 100000);
                }
            }
        }

        private static int GetSalarySumForMonth(int month, int[,] salaryDatabase) {

            var result = 0;
            for (var i = 0; i < salaryDatabase.GetLength(0); i++)
            {
                result += salaryDatabase[i, month];
            }

            return result;
        }
    }
}
