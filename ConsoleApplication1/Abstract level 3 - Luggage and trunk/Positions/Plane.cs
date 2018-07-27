using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class Plane
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;

        public Plane(Point A, Point B, Point C, Point D)
        {
            this.A = new Point(A.X, A.Y, A.Z);
            this.B = new Point(B.X, B.Y, B.Z);
            this.C = new Point(C.X, C.Y, C.Z);
            this.D = new Point(D.X, D.Y, D.Z);
        }

        public Plane(Point startingPoint, int width, int height, int depth)
        {
            this.A = new Point(startingPoint.X, startingPoint.Y, depth);
            this.B = new Point(this.A.X + width, this.A.Y, depth);
            this.C = new Point(this.B.X, this.B.Y + height, depth);
            this.D = new Point(this.A.X, this.C.Y, depth);
        }
    }
}
