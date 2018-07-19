using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class TrunkSizeChecker
    {
        private Trunk trunk = null;
        private LuggageList luggageList = null;

        public TrunkSizeChecker(LuggageList luggageList, IContainer trunk)
        {
            if (luggageList == null || trunk == null)
            {
                throw new ArgumentNullException("Luggage list or trunk not existing");
            }

            this.luggageList = luggageList;
            this.trunk = (Trunk)trunk;
        }

        public bool evaluateTrunkSize()
        {
            bool volumeOK = checkSingleVolumeOfEveryLuggage() && checkSummaryVolume();
            bool dimXYZOK = checkXYZdimensions();

            Console.WriteLine("Volume OK: {0}, XYZ OK: {1}", volumeOK, dimXYZOK);

            return volumeOK && dimXYZOK;
        }

        private bool checkSingleVolumeOfEveryLuggage()
        {
            bool volumeIsEnough = true;
            Console.WriteLine("Dlugosc listy bagazy w TrunkSizeChecker: {0}", luggageList.getLength());
            for (int i = 0; i < luggageList.getLength(); i++)
            {
                volumeIsEnough = volumeIsEnough & checkSingleVolume(luggageList.getLuggage(i));
            }
            return volumeIsEnough;
        }

        private bool checkSingleVolume(IContainer luggage)
        {
            bool isLuggageVolumeSmaller = false;
            if (luggage.getVolume() < trunk.getVolume())
            {
                isLuggageVolumeSmaller = true;
            }

            Console.WriteLine("Luggage volume: {0}, Trunk volume: {1}, Evaluation: {2}", luggage.getVolume(), trunk.getVolume(), isLuggageVolumeSmaller);

            return isLuggageVolumeSmaller;
        }

        private bool checkSummaryVolume()
        {
            int summaryVolume = 0;
            bool summaryVolumeInRange = false;

            for (int i = 0; i < luggageList.getLength(); i++)
            {
                summaryVolume += luggageList.getLuggage(i).getVolume();
            }

            if (summaryVolume > trunk.getVolume())
            {
                summaryVolumeInRange = false;
            }
            else
            {
                summaryVolumeInRange = true;
            }

            return summaryVolumeInRange;
        }

        private bool checkXYZdimensions()
        {
            bool trunkHasXYZEnough = true;
            for (int i = 0; i < luggageList.getLength(); i++)
            {
                trunkHasXYZEnough = trunkHasXYZEnough && checkXYZdimensionsForSingleLuggage(luggageList.getLuggage(i));
            }

            return trunkHasXYZEnough;
        }

        private bool checkXYZdimensionsForSingleLuggage(IContainer luggage)
        {
            bool luggageFitsToTrunk = false;

            if (trunk.checkXYZdimemsions(luggage))
            {
                luggageFitsToTrunk = true;
            }

            return luggageFitsToTrunk;
        }
    }
}
