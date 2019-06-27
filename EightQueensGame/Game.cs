using System;

namespace EigthQueensGame
{
    public enum SquareStates
    {
        Null,
        Queen,
        QueenVision
    }
    public class Game
    {
        private readonly SquareStates[,] _squares;
        private bool _playing;
        private int _x;
        private int _y;


        public Game()
        {
            _squares = new SquareStates[8,8];
            _playing = true;
        }


        public void Play()
        {
            while (_playing)
            {
                ShowBoard();
                
                Console.WriteLine("Write a Position");

                var x = Console.ReadLine();
                var y = Console.ReadLine();
                
                InsertQueen(int.Parse(x), int.Parse(y));
            }
        }

        private void ShowBoard()
        {
            for (var j = 0; j < 8; j++)
            {
                for (var i = 0; i < 8; i++)
                {
                    if (_squares[i, j] == SquareStates.Queen)
                    {
                        Console.Write(" [ RA ] ");
                    }
                    else if (_squares[i, j] == SquareStates.QueenVision)
                    {
                        Console.Write(" [ QV ] ");
                    }
                    else
                    {
                        Console.Write($" [{i+1}, {j+1}] ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        private void InsertQueen(int x, int y)
        {
            _x = x-1;
            _y = y-1;

            _squares[_x, _y] = SquareStates.Queen;

            HorizontalMovement(_y);
            VerticalMovement(_x);
            UpRightMovement(_x, _y);
            UpLeftMovement(_x, _y);
            DownRightMovement(_x, _y);
            DownLeftMovement(_x, _y);
        }

        private void HorizontalMovement(int b)
        {
            for (var i = 0; i < 8; i++)
            {
                VerifyIfLose(i, _y);
            }
        }

        private void VerticalMovement(int a)
        {
            for (var i = 0; i < 8; i++)
            {
                VerifyIfLose(a, i);
            }
        }

        private void UpRightMovement(int a, int b)
        {
            do
            {
                VerifyIfLose(a, b);
                a++;
                b--;
            } while (a > 0 && a < 7 && b > 0 && b < 7);
        }

        private void UpLeftMovement(int a, int b)
        {
            do
            {
                VerifyIfLose(a, b);
                a--;
                b--;
            } while (a > 0 && a < 7 && b > 0 && b < 7);
        }

        private void DownRightMovement(int a, int b)
        {
            do
            {
                VerifyIfLose(a, b);
                a++;
                b++;
            } while (a > 0 && a < 7 && b > 0 && b < 7);
        }

        private void DownLeftMovement(int a, int b)
        {
            do
            {
                VerifyIfLose(a, b);
                a--;
                b++;
            } while (a > 0 && a < 7 && b > 0 && b < 7);
        }

        private void VerifyIfLose(int a, int b)
        {
            if (_squares[a, b] == SquareStates.Queen)
            {
                if (_x != a && _y != b)
                {
                    _playing = false;
                }
            }
            else
            {
                _squares[a, b] = SquareStates.QueenVision;
            }
        }
    }
}