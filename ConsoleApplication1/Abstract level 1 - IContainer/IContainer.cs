using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    interface IContainer
    {
        // methods required to implement IComparable
        string ToString();
        bool Equals(object otherLuggage);
        int GetHashCode();
        int CompareTo(object otherLuggage);

        int getVolume();
        int getDimX();
        int getDimY();
        int getDimZ();
    }
}
