using System;

namespace EigthQueensGame
{
    public class Game
    {
        private bool[,] Squares;
        private bool Playing;


        public Game()
        {
            Squares = new bool[7,7];
            Playing = true;
        }


        public void Play()
        {
            while (Playing)
            {
                for (var i = 0; i < 7; i++)
                {
                    for (var j = 0; j < 7; j++)
                    {
                        Console.Write(Squares[i, j] ? "R " : " X ");
                    }
                    Console.WriteLine("");
                }

                Playing = false;
            }
        }
    }
}