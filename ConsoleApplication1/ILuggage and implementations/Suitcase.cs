using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class Suitcase : IContainer, IComparable
    {
        private int dimX = 0; // cm
        private int dimY = 0; // cm
        private int dimZ = 0; // cm
        private int volume = 0; // cm -- max volume = MAXIMUM_LUGGAGE_DIMENSION*MAXIMUM_LUGGAGE_DIMENSION*MAXIMUM_LUGGAGE_DIMENSION = 100*100*100 = 1 000 000
        private readonly int MINIMUM_LUGGAGE_DIMENSION = 10; // cm
        private readonly int MAXIMUM_LUGGAGE_DIMENSION = 100; // cm

        public Suitcase()
        {
            dimX = MINIMUM_LUGGAGE_DIMENSION;
            dimY = MINIMUM_LUGGAGE_DIMENSION;
            dimZ = MINIMUM_LUGGAGE_DIMENSION;
            volume = calculateVolume();
        }

        public Suitcase(int dimX, int dimY, int dimZ)
        {
            if(isLuggageValid(dimX, dimY, dimZ))
            {
                this.dimX = dimX;
                this.dimY = dimY;
                this.dimZ = dimZ;
                volume = calculateVolume();
            }
            else
            {
                throw new ArgumentOutOfRangeException("One of the dimensions is out of range");
            }
        }

        public override string ToString()
        {
            return string.Format("Dimension X: {0}, Dimension Y: {1}, Dimension Z: {2}, Volume: {3}", dimX, dimY, dimZ, volume);
        }

        public override bool Equals(object otherLuggage)
        {
            bool passedObjectNotEmptyAndProperType = otherLuggage != null && otherLuggage is IContainer;
            bool volumesAreEqual = volume == ((IContainer)otherLuggage).getVolume();

            bool areEqual = passedObjectNotEmptyAndProperType && volumesAreEqual;

            return areEqual;
        }

        public override int GetHashCode()
        {
            return this.volume.GetHashCode();
        }

        public int getVolume()
        {
            return volume;
        }

        public int getX()
        {
            return dimX;
        }

        public int getY()
        {
            return dimY;
        }

        public int getZ()
        {
            return dimZ;
        }

        public int CompareTo(object otherLuggage)
        {
            const int RESULT_VOLUMES_ARE_EQUAL = 0;
            const int RESULT_THIS_IS_GREATER_AS_OTHER_LUGGAGE = 1;
            const int RESULT_THIS_IS_SMALLER_AS_OTHER_LUGGAGE = -1;

            bool passedObjectNotEmptyAndProperType = otherLuggage != null && otherLuggage is IContainer;
            bool volumesAreEqual = passedObjectNotEmptyAndProperType && Equals(otherLuggage);
            bool thisIsGreaterAsOtherLuggage = passedObjectNotEmptyAndProperType && volume > ((IContainer)otherLuggage).getVolume();
            bool thisIsSmallerAsOtherLuggage = passedObjectNotEmptyAndProperType && volume < ((IContainer)otherLuggage).getVolume();

            if (volumesAreEqual)
            {
                return RESULT_VOLUMES_ARE_EQUAL;
            }
            else if (thisIsGreaterAsOtherLuggage)
            {
                return RESULT_THIS_IS_GREATER_AS_OTHER_LUGGAGE;
            }
            else if (thisIsSmallerAsOtherLuggage)
            {
                return RESULT_THIS_IS_SMALLER_AS_OTHER_LUGGAGE;
            }
            else throw new ArgumentOutOfRangeException("Luggage volume compare failed");
        }

        private bool isLuggageValid(int dimX, int dimY, int dimZ)
        {
            bool dimXisOK = false;
            dimXisOK = checkDimenstionsConstrains(dimX);

            bool dimYisOK = false;
            dimYisOK = checkDimenstionsConstrains(dimY);

            bool dimZisOK = false;
            dimZisOK = checkDimenstionsConstrains(dimZ);

            bool dimmensionCheckResult = dimXisOK && dimYisOK && dimZisOK;
            return dimmensionCheckResult;
        }

        private bool checkDimenstionsConstrains(int dimension)
        {
            bool minimumSizeOK = false;
            bool maximumSizeOK = false;
            bool constrainsCheckResult = false;

            if (MINIMUM_LUGGAGE_DIMENSION <= dimension)
            {
                minimumSizeOK = true;
            }

            if (dimension <= MAXIMUM_LUGGAGE_DIMENSION)
            {
                maximumSizeOK = true;
            }

            constrainsCheckResult = maximumSizeOK && minimumSizeOK;
            return constrainsCheckResult;
        }

        private int calculateVolume()
        {
            int volume = dimX * dimY * dimZ;

            return volume;
        }

    }
}
