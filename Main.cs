using System;
using System.Threading;


namespace zmeika
{
    class Game
    {

        static public void draw(Snake snake, Board board)
        {
            Console.Beep();
            Console.Clear();
            board.outBoard();
        }

        static public void update(Snake snake, Board board)
        {

        }


        static public void WHT()
        {
            switch(Console.ReadKey(true).Key.ToString())
            {
                case "A":
                    Console.WriteLine("Left");
                    break;
                case "S":
                    Console.WriteLine("DOWN");
                    break;
                case "W":
                    Console.WriteLine("UP");
                    break;
                case "D":
                    Console.WriteLine("RIGHT");
                    break;

            }
        }

        static void Main()
        {
            
            Board Test = new Board();
            Snake First = new Snake();
            First.includeInGame(Test.getBoard());
            bool a = true;
            do
            {
                draw(First, Test);
                First.goline(Test.getBoard());
            }
            while (a);
            Console.ReadKey();

        }

    }
}