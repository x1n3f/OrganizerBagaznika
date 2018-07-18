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

        public LuggageCalc(LuggageList content, IContainer container)
        {
            if (content == null || container == null)
            {
                throw new ArgumentNullException("Empty object");
            }

            this.content = content;
            this.container = (Trunk) container;
        }

        //TODO: zmienic, zeby kazdy bagaz sprawdzac pojedynczo + sumaryczna objetosc
        private bool isTrunkBigEnough()
        {
            bool trunkIsBigEnough = true;
            bool oneLuggageFits = false;
            for(int i = 0; i < content.getLength(); i++)
            {
                oneLuggageFits = container.doesLuggageFitsToTrunk(content.getLuggage(i));
                trunkIsBigEnough = trunkIsBigEnough && oneLuggageFits;
            }

            return trunkIsBigEnough;
        }

        private bool checkIfLuggageFitsToTrunk(IContainer luggage)
        {

            return false;
        }
 
    }
}
