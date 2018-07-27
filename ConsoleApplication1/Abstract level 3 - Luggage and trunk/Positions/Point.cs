using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class Point
    {
        private int x;
        private int y;
        private int z;

        private readonly int UPPER_LIMIT = 1000;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > 0 && value < UPPER_LIMIT) x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 0 && value < UPPER_LIMIT) y = value;
            }
        }

        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                if (value > 0 && value < UPPER_LIMIT) z = value;
            }
        }


    }
}
