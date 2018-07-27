using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    sealed class Suitcase : Box
    {
        private string friendlyName = "";

        public Suitcase() : base()
        {
            friendlyName = "Suitcase";
        }

        public Suitcase(int dimX, int dimY, int dimZ) : base(dimX, dimY, dimZ)
        {
        }

        public Suitcase(string friendlyName, int dimX, int dimY, int dimZ) : base(dimX, dimY, dimZ)
        {
            this.friendlyName = friendlyName;
        }


    }
}
