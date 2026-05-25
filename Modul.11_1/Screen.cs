using System;
using System.Collections.Generic;
using System.Text;

namespace Modul._11_1
{
    internal class Screen
    {
        public int X;
        public int Y;
        public Screen(int x, int y)
        {
            this.X = AralikDenetleX(x);
            this.Y = AralikDenetleY(y);
        }

        public int OkuX()
        {
            return X;
        }

        public void YazX(int yeniX)
        {
            this.X = AralikDenetleX(yeniX);
        }

        private static int AralikDenetleX(int x)
        {
            if (x < 0 || x > 1280)
            {
                throw new ArgumentOutOfRangeException("X");
            }

            return x;
        }

        private static int AralikDenetleY(int y)
        {
            if (y < 0 || y > 1024)
            {
                throw new ArgumentOutOfRangeException("Y");
            }

            return y;
        }
    }

    struct Screen2
    {
        public Screen2(int x, int y)
        {
            this.x = AralikDenetleX(x);
            this.y = AralikDenetleY(y);
        }

        private int x;

        public int X
        {
            get { return this.x; }
            set { this.x = AralikDenetleX(value); }
        }

        private int y;

        public int Y
        {
            get { return this.y; }
            set { this.y = AralikDenetleY(value); }
        }

        private static int AralikDenetleX(int x)
        {
            if (x < 0 || x > 1280)
            {
                throw new ArgumentOutOfRangeException("X");
            }

            return x;
        }

        private static int AralikDenetleY(int y)
        {
            if (y < 0 || y > 1024)
            {
                throw new ArgumentOutOfRangeException("Y");
            }

            return y;
        }

    }
}
