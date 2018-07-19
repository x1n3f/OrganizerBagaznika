using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class LuggageCalc
    {
        private Trunk container = null;
        private LuggageList content = null;

        public LuggageCalc(LuggageList luggageList, IContainer trunk)
        {
            if (luggageList == null || trunk == null)
            {
                throw new ArgumentNullException("Luggage list or trunk not existing");
            }

            this.content = luggageList;
            this.container = (Trunk) trunk;
        }

        private bool isTrunkBigEnough()
        {
            bool trunkIsBigEnough = true;
            for(int i = 0; i < content.getLength(); i++)
            {
                trunkIsBigEnough = trunkIsBigEnough && doesLuggageFitToTrunk(content.getLuggage(i));
            }

            return trunkIsBigEnough;
        }

        private bool doesLuggageFitToTrunk(IContainer luggage)
        {
            bool luggageFitsToTrunk = false;

            if (container.doesLuggageFitsToTrunk(luggage))
            {
                luggageFitsToTrunk = true;
            }

            return luggageFitsToTrunk;
        }

        private bool checkIfLuggageFitsToTrunk(IContainer luggage)
        {

            return false;
        }
 
    }
}
