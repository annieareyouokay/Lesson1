using Utilities;

namespace TicTacToe
{
    internal class Program
    {
        enum Players
        {
            x = 1,
            o,
        }

        private static int previousTurn = 0;
        private static int[] gameField = new int[9];
        private static bool gameOver = false;

        static void Main(string[] args)
        {
            StartGame();
        }

        private static void StartGame()
        {
            Init();
            while (true)
            {
                Console.WriteLine($"Введите ход: ");
                var turn = Auxiliary.GetNumber();
                Update(turn);
                Draw();
            }
        }

        private static void Draw()
        {
            for (int i = 0; i < gameField.Length; i++)
            {
                if (i == 3 || i == 6)
                {
                    Console.WriteLine();
                }
                Console.Write((Players)gameField[i] + " ");
            }
            Console.WriteLine();
        }

        private static void Init()
        {
            Console.WriteLine("---Tic-Tac-Toe---");
        }

        private static void Update(int fieldNumber)
        {
            if (previousTurn == 0)
            {
                gameField[fieldNumber - 1] = (int)Players.x;
                previousTurn = fieldNumber;
                return;
            }

            gameField[fieldNumber - 1] = gameField[previousTurn - 1] == (int)Players.x ? (int)Players.o : (int)Players.x;

            if (IsWin())
            {
                Console.WriteLine("Player wins");
            }

            if (IsDraw())
            {
                Console.WriteLine("is draw");
            }
        }

        private static bool IsWin()
        {
            return false;
        }

        private static bool IsDraw()
        {
            return false;
        }

        private static void Exit()
        {
            Environment.Exit(0);
        }
    }

}
