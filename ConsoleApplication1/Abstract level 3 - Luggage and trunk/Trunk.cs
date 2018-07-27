using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    sealed class Trunk : Box
    {
        public Trunk() : base()
        {
        }

        public Trunk(int dimX, int dimY, int dimZ) : base(dimX, dimY, dimZ)
        {
            Console.WriteLine("New Trunk");
        }

        public bool checkXYZdimemsions(IContainer luggage)
        {
            int luggageDimX = luggage.getDimX();
            int luggageDimY = luggage.getDimY();
            int luggageDimZ = luggage.getDimZ();

            bool dimX_OK = false;
            if (luggageDimX <= getDimX())
            {
                dimX_OK = true;
            }

            bool dimY_OK = false;
            if (luggageDimY <= getDimY())
            {
                dimY_OK = true;
            }

            bool dimZ_OK = false;
            if (luggageDimZ <= getDimZ())
            {
                dimZ_OK = true;
            }

            bool luggageFitsToTrunk = dimX_OK && dimY_OK && dimZ_OK;

            return luggageFitsToTrunk;
        }
    }
}
