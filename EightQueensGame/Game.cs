using System;

namespace EigthQueensGame
{
    public class Game
    {
        private bool[,] Squares;
        private bool Playing;


        public Game()
        {
            Squares = new bool[8,8];
            Playing = true;
        }


        public void Play()
        {
            while (Playing)
            {
                ShowBoard();

                InsertQueen(4, 6);
                
                
                ShowBoard();

                Playing = false;
            }
        }

        private void ShowBoard()
        {
            for (var j = 0; j < 8; j++)
            {
                for (var i = 0; i < 8; i++)
                {
                    Console.Write(Squares[i, j] ? " R " : " X ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        private void InsertQueen(int x, int y)
        {
            x -= 1;
            y -= 1;
            Squares[x, y] = true;

            for (var i = 0; i < 8; i++)
            {
                Squares[x, i] = true;
            }

            for (var i = 0; i < 8; i++)
            {
                Squares[i, y] = true;
            }

//            for (var i = 0; i < 7; i++)
//            {
//                Squares[i, i] = true;
//            }
            
        }
    }
}