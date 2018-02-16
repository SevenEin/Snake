using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeika
{
    class Board
    {
        char[,] realBoard = new char[12,32]; // создает разметку доски(конструктор)
        public Board()
        {
            for (int i = 0; i < 12; i++)
            {
                if (i == 0)
                {
                    for (int g = 0; g < 32; g++)
                    {
                        if (g > 0 && g < 31)
                            realBoard[i, g] = '_';
                        else
                            realBoard[i, g] = 'Y';
                    }
                }
                else if (i == 11)
                {
                    for (int g = 0; g < 32; g++)
                    {
                        if (g > 0 && g < 31)
                            realBoard[i, g] = '_';
                        else
                            realBoard[i, g] = 'Y';
                    }
                }
                else
                { 
                    for (int g = 0; g < 32; g++)
                    {
                        if (g == 0 || g == 31)
                        {
                            realBoard[i, g] = '|';
                        }
                        else
                        realBoard[i, g] = ' ';
                    }
                }
            }
        }

        public void outBoard() // выводит доску на экран;
        {
            Console.WriteLine();
            for (int a = 0; a < 12; a++)
            {
                Console.WriteLine();
                for (int b = 0; b < 32; b++)
                {
                    Console.Write(realBoard[a,b]);
                }
            }

        }

        public char[,] getBoard()
        {
            return realBoard;
        }

    }
}
