using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeika
{

    class Snake // сама змея, че умеет из чего состоит
    {
        pieceBody[] arrSnake = new pieceBody[3];
        char vector = 'r';

        public char Vector
        {
            get
            {
                return vector;
            }
            set
            {
                // w - вверх, d - вправо, a - лево, s - низ кнопки клавиатуры: 'u' - вверх, r - вправо, l - лево - d - низ, значение
                char temp = Char.ToLower(value);

                switch (temp)
                {
                    case 'w':
                        {
                            if (vector == 'd' | vector == 'a')
                                vector = 'u';
                            break;
                        }
                    case 's':
                        {
                            if (vector == 'd' | vector == 'a')
                                vector = 's';
                            break;
                        }
                    case 'd':
                        {
                            if (vector == 'w' | vector == 's')
                                vector = 'd';
                            break;
                        }
                    case 'a':
                        {
                            if (vector == 'w' | vector == 's')
                                vector = 'a';
                            break;
                        }
                    default:
                        break;

                }
            }
        }

        private pieceBody createHead() //создание головы змеи
        {
            pieceBody Temp = new pieceBody();
            Random random = new Random();
            Temp.A = random.Next(1, 10);
            Temp.B = random.Next(1, 30);

            return Temp;
        }

        public Snake() // создание тела змеии
        {
            arrSnake[0] = createHead();
            for (int i = 1; i < arrSnake.Length; i++)
            {
                arrSnake[i] = new pieceBody();
                int Y = arrSnake[i - 1].B;
                arrSnake[i].B = (Y - 1);
                arrSnake[i].A = arrSnake[i - 1].A;

            }
        }

        public void includeInGame(char[,] board) // включает в доску;
        {
            for (int a = 0; a < arrSnake.Length; a++)
            {
                int X = arrSnake[a].A;
                int Y = arrSnake[a].B;
                int head = arrSnake[a].position();
                if (head != 1)
                    board[X, Y] = 'X';
                else
                    board[X, Y] = 'O';
            }
        }

        public void goline(char[,] step) // ход по прямой с вектором вправо
        {
            clear(step);

            for (int a = 0; a < arrSnake.Length; a++)
            {
                {
                    if (a == 0) // 0 является головой змеии, первый индекс
                    {
                        arrSnake[a].B = arrSnake[a].B + 1;
                        continue;
                    }
                    int Y = arrSnake[a - 1].B;
                    arrSnake[a].B = (Y - 1);
                    arrSnake[a].A = arrSnake[a - 1].A;
                }
            }

            includeInGame(step);
        }

        private void clear(char[,] brd)
        {
            int temp = arrSnake.Length;
            pieceBody Temp = arrSnake[temp - 1];
            brd[Temp.A, Temp.B] = ' ';
        }


        private void changepos(char hat, char[,] step)
        {
            switch(hat)
            {
                case 'r':
                    for(int a = 0; a < arrSnake.Length; a++)
                    { 
                    if (a == 0) // 0 является головой змеии, первый индекс
                    {
                        arrSnake[a].B = arrSnake[a].B + 1;
                        continue;
                    }
                    int Y = arrSnake[a - 1].B;
                    arrSnake[a].B = (Y - 1);
                    arrSnake[a].A = arrSnake[a - 1].A;
                    }
            break;
                case 'l':
                    break;
                case 'u':
                    break;
                case 'd':
                    break;
            }
            for (int a = 0; a < arrSnake.Length; a++)
            {
                {
                    if (a == 0) // 0 является головой змеии, первый индекс
                    {
                        arrSnake[a].B = arrSnake[a].B + 1;
                        continue;
                    }
                    int Y = arrSnake[a - 1].B;
                    arrSnake[a].B = (Y - 1);
                    arrSnake[a].A = arrSnake[a - 1].A;
                }
            }

        }
    }

}
