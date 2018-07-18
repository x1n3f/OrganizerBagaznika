using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    interface ILuggage
    {
        // methods required to implement IComparable
        string ToString();
        bool Equals(object otherLuggage);
        int GetHashCode();
        int CompareTo(object otherLuggage);

        int getVolume();
        int getX();
        int getY();
        int getZ();
    }
}
