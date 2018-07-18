using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class LuggageList
    {
        private List<ILuggage> luggageToBePackedIntoTrunk = new List<ILuggage>();

        public void addLuggage(ILuggage luggage)
        {
            luggageToBePackedIntoTrunk.Add(luggage);
        }

        public void getLuggage(int position)
        {

        }

        public void sortVolume()
        {
            luggageToBePackedIntoTrunk.Sort();
        }

        public void sortX()
        {
            luggageToBePackedIntoTrunk.Sort(new LuggageCompareX());
        }

        public void sortY()
        {
            luggageToBePackedIntoTrunk.Sort(new LuggageCompareY());
        }

        public void sortZ()
        {
            luggageToBePackedIntoTrunk.Sort(new LuggageCompareZ());
        }

        public void sortMaxXYZ()
        {
            luggageToBePackedIntoTrunk.Sort(new LuggageCompareMaxXYZ());
        }

        public override string ToString()
        {
            string outputString = "";
            foreach (ILuggage luggage in luggageToBePackedIntoTrunk)
            {
                outputString += luggage + "\n";
            }

            return outputString;
        }
    }
}
