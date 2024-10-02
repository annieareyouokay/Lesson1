namespace MonthDays
{
    internal class Program
    {
        enum Month
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            int GetNumber()
            {
                int number;
                Console.WriteLine("Введите число от 1 до 12: ");
                while (!int.TryParse(Console.ReadLine(), out number) || (number > 12 || number < 1))
                {
                    
                    Console.WriteLine("Введенный вами символ не является числом или находится вне диапазона 1 - 12. Попробуйте ещё раз: ");
                }

                return number;
            }

            Console.WriteLine((Month)GetNumber());
        }
    }

}
