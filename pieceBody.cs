using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeika
{
    class pieceBody
    {
        int a;
        int b;
        static int how_much = 0;
        int index = 0;

        static private int element() // приближение
        {
            how_much = how_much + 1;
            return how_much;
        }

        public pieceBody() // конструктор, задает куску тела под каким оно номером
        {
            index = element();
        }

        public int position() // какой элемент в теле
        {
            return index;
        }

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value < 1)
                    a = 10;
                else if (value > 10)
                    a = 1;
                else
                    a = value;
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value < 1)
                    b = 30;
                else if (value > 30)
                    b = 1;
                else
                    b = value;
            }
        }



    }
}
