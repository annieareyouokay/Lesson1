using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        private const string gap = "     ";
        private const int _rowCount = 3;
        private const int _columnCount = 3;
        private char currentTurn = player1;
        private char[,] gameBoard = new char[_rowCount, _columnCount]
        {
            { emptyCell, emptyCell, emptyCell },
            { emptyCell, emptyCell, emptyCell },
            { emptyCell, emptyCell, emptyCell }
        };
        private bool isGameOver = false;
        private const char player1 = 'X';
        private const char player2 = 'O';
        private const char emptyCell = ' ';
        private int freeCells = 9;
        private const string description = """
                Крестики-нолики — это простая логическая игра для двух игроков. 
                Игроки по очереди ставят свои символы (крестики или нолики) на поле размером 3x3. 
                Цель каждого игрока — первым выстроить три своих символа в ряд по горизонтали, вертикали или диагонали. 
                Игра заканчивается, когда один из игроков выполняет условие победы, либо когда все клетки поля заняты (ничья).

                Правила игры:
                Поле представляет собой сетку 3x3.
                Два игрока по очереди выбирают клетки, где они хотят разместить свои символы: один игрок ставит "X", другой — "O".
                Первый игрок, который выстроит три своих символа по горизонтали, вертикали или диагонали, побеждает.
                Если все клетки заполнены, а победителя нет — объявляется ничья.

                Доступные команды:
                -new — начать новую игру. Поле будет очищено, и игроки смогут начать заново.
                -exit — завершить игру и выйти из приложения.
                -help - получить описание игры.
                """;


        public void StartGame()
        {
            Init();
            while (!isGameOver)
            {
                Console.Write($"Введите номер строки: ");
                var row = GetTurn(_rowCount);
                Console.Write($"Введите номер колонки: ");
                var column = GetTurn(_columnCount);
                Update(--row, --column);
                Draw();

                if (isGameOver)
                {
                    Console.WriteLine("Начать новую игру? Для этого введите \"Yes(Y)\" - да начать, \"No(N)\" - нет закончить");
                    var input = Console.ReadLine();
                    if (input.ToLower() == "yes" || input.ToLower() == "y")
                    {
                        NewGame();
                    }
                }
            }
        }

        private void Draw()
        {
            Console.WriteLine();
            Console.Write("{0} {1} | {2} | {3} ", gap, gameBoard[0, 0], gameBoard[0, 1], gameBoard[0, 2]);
            Console.Write("{0}{1}---+---+---", Environment.NewLine, gap);
            Console.Write("{0}{1} {2} | {3} | {4} ", Environment.NewLine, gap, gameBoard[1, 0], gameBoard[1, 1], gameBoard[1, 2]);
            Console.Write("{0}{1}---+---+---", Environment.NewLine, gap);
            Console.Write("{0}{1} {2} | {3} | {4} {5}", Environment.NewLine, gap, gameBoard[2, 0], gameBoard[2, 1], gameBoard[2, 2], Environment.NewLine);
            Console.WriteLine();
        }

        private void Init()
        {
            Console.WriteLine(" ===================");
            Console.WriteLine(" =                 =");
            Console.WriteLine(" = Крестики-нолики =");
            Console.WriteLine(" =                 =");
            Console.WriteLine(" ===================");
            Draw();
            Console.WriteLine("\"-help\" - справка");
        }

        private void Update(int row, int column)
        {
            if (gameBoard[row, column] != emptyCell)
            {
                Console.WriteLine("Поля занятно игроком \"{0}\"", gameBoard[row, column]);
                return;
            }

            gameBoard[row, column] = currentTurn;
            --freeCells;
            if (IsWin())
            {
                Console.WriteLine("Поздравляем! Игрок \"{0}\" победил!", currentTurn);
                isGameOver = true;
            }

            if (IsDraw())
            {
                Console.WriteLine("Это ничья!");
                isGameOver = true;
            }
            currentTurn = currentTurn == player1 ? player2 : player1;
        }

        private bool IsWin()
        {
            for (int i = 0; i < _rowCount; i++)
            {
                if (gameBoard[i, 0] == currentTurn && gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 0] == gameBoard[i, 2])
                {
                    return true;
                }

                if (gameBoard[0, i] == currentTurn && gameBoard[0, i] == gameBoard[1, i] && gameBoard[0, i] == gameBoard[2, i])
                {
                    return true;
                }
            }

            if (gameBoard[1, 1] == currentTurn && gameBoard[1, 1] == gameBoard[0, 0] && gameBoard[1, 1] == gameBoard[2, 2])
            {
                return true;
            }

            if (gameBoard[1, 1] == currentTurn && gameBoard[1, 1] == gameBoard[0, 2] && gameBoard[1, 1] == gameBoard[2, 0])
            {
                return true;
            }

            return false;
        }

        private bool IsDraw()
        {
            if (freeCells <= 0)
            {
                return true;
            }

            return false;
        }

        public static string GetDescription() => description;

        private int GetTurn(int limit)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Вы ничего не ввели. Попробуйте ещё раз: ");
                    continue;
                }

                int number;
                if (!int.TryParse(input, out number))
                {
                    if (input.StartsWith("-"))
                    {
                        ProcessCommand(input);
                        continue;
                    }

                    Console.WriteLine("Введенный вами символ не является числом. Попробуйте ещё раз: ");
                    continue;
                }

                if (number > limit)
                {
                    Console.WriteLine("Число вне диапазона игрового поля. Попробуйте ещё раз.");
                    continue;
                }

                return number;
            }
        }

        private void ProcessCommand(string input)
        {
            switch (input)
            {
                case "-exit":
                    Exit();
                    break;
                case "-help":
                    Console.WriteLine(GetDescription());
                    break;
                case "-new":
                    NewGame();
                    break;
                default:
                    Console.WriteLine("Неизвестная команда.");
                    break;
            }
        }

        private void NewGame()
        {
            currentTurn = player1;
            isGameOver = false;
            freeCells = 9;
            gameBoard = new char[_rowCount, _columnCount]
                {
                { emptyCell, emptyCell, emptyCell },
                { emptyCell, emptyCell, emptyCell },
                { emptyCell, emptyCell, emptyCell }
                };
            StartGame();
        }

        private static void Exit()
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
