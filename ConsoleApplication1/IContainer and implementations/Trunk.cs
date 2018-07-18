using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class Trunk : Box
    {
        public Trunk() : base()
        {
        }

        public Trunk(int dimX, int dimY, int dimZ) : base(dimX, dimY, dimZ)
        {
            Console.WriteLine("New Trunk");
        }

        public bool doesLuggageFitsToTrunk(IContainer luggage)
        {
            int luggageDimX = luggage.getX();
            int luggageDimY = luggage.getY();
            int luggageDimZ = luggage.getZ();

            bool dimX_OK = false;
            if (luggageDimX <= getX())
            {
                dimX_OK = true;
            }

            bool dimY_OK = false;
            if (luggageDimX <= getY())
            {
                dimY_OK = true;
            }

            bool dimZ_OK = false;
            if (luggageDimY <= getZ())
            {
                dimZ_OK = true;
            }

            bool luggageFitsToTrunk = dimX_OK && dimY_OK && dimZ_OK;

            return luggageFitsToTrunk;
        }
    }
}
