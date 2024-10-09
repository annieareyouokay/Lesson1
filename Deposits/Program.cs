using System.Diagnostics.Metrics;
using Utilities;

namespace Deposits
{
    internal class Program
    {
        private const float rate = 0.02f;
        private const int MonthCountForProfit = 10;
        private const int MonthCountForDepositSums = 12;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемую сумму для депозита:");
            var deposit = (double)Auxiliary.GetNumber();
            Console.WriteLine("Только прирост в течении 10 месяцев: ");
            ShowProfitByMonth(deposit, MonthCountForProfit);
            Console.WriteLine(Environment.NewLine + "Сумма вклада в течении 12 месяцев: ");
            ShowDepositWithProfitByMonth(deposit, MonthCountForProfit);
        }

        private static void ShowProfitByMonth(double deposit, int counter)
        {
            if (counter <= 0)
            {
                return;
            }
            var profit = Math.Round(deposit * rate, 2);
            Console.Write(profit + "  ");
            ShowProfitByMonth(deposit + profit, --counter);
        }
        private static void ShowDepositWithProfitByMonth(double deposit, int counter)
        {
            if (counter <= 0)
            {
                return;
            }
            var profitWithDeposit = Math.Round(deposit + (deposit * rate), 2);
            Console.Write(profitWithDeposit + "  ");
            ShowDepositWithProfitByMonth(profitWithDeposit, --counter);
        }
    }
}
