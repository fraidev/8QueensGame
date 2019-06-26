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

                //3 5
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
                    Console.Write(Squares[i, j] ? " [ RA ] " : $" [{i}, {j}] ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        private void InsertQueen(int x, int y)
        {
            Squares[x, y] = true;

            //Vertical Movement
            for (var i = 0; i < 8; i++)
            {
                Squares[x, i] = true;
            }
            
            //Horizontal Movement
            for (var i = 0; i < 8; i++)
            {
                Squares[i, y] = true;
            }
            
            //UP RIGHT MOVEMENT
            for (var i = x; i < 8; i++)
            {
                var retval = y--;
                Squares[i, retval] = true;
            }
            
            //UP RIGHT MOVEMENT
            for (var i = x; i == 0; i++)
            {
                var retval = y--;
                Squares[i, retval] = true;
            }
            
            //UP LEFT MOVEMENT
            for (var i = x; i > 0; i--)
            {
                var retval = y++;
                Squares[i, retval] = true;
            }
        }
    }
}