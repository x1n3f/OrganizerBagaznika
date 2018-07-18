using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class ComparerLogic
    {
        private readonly int VALUES_ARE_EQUAL = 0;
        private readonly int VALUE_1_IS_BIGGER = 1;
        private readonly int VALUE_1_IS_SMALLER = -1;

        int sthToCompare1 = 0;
        int sthToCompare2 = 0;
        int compareResult = 0;

        public ComparerLogic(int input1, int input2)
        {
            this.sthToCompare1 = input1;
            this.sthToCompare2 = input2;
        }

        public int compare()
        {
            compareResult = calculate();
            return compareResult;
        }

        private int calculate()
        {
            if (sthToCompare1 == sthToCompare2)
            {
                return VALUES_ARE_EQUAL;
            }
            else if (sthToCompare1 > sthToCompare2)
            {
                return VALUE_1_IS_BIGGER;
            }
            else
            {
                return VALUE_1_IS_SMALLER;
            }
        }
    }
}
