#undef DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class LuggageCalc
    {
        private Trunk trunk = null;
        private LuggageList luggageList = null;
        private bool isTrunkBigEnough = false;


        public LuggageCalc(LuggageList luggageList, IContainer trunk)
        {
            if (luggageList == null || trunk == null)
            {
                throw new ArgumentNullException("Luggage list or trunk not existing");
            }

            this.luggageList = luggageList;
            this.trunk = (Trunk) trunk;

            TrunkSizeChecker checkTrunksSize = new TrunkSizeChecker(luggageList, trunk);
            isTrunkBigEnough = checkTrunksSize.evaluateTrunkSize();

            DebugSupporter.printPropertyValue(nameof(isTrunkBigEnough), isTrunkBigEnough);          
        }



    }
}
