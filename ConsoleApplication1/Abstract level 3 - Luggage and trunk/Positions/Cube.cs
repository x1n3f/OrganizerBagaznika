using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class Cube
    {
        private Plane front;
        private Plane back;

        Cube(Point startingPoint, int width, int height, int depth)
        {
            front = new Plane(startingPoint, width, height, 0);
            back = new Plane(startingPoint, width, height, depth);
        }
    }
}
