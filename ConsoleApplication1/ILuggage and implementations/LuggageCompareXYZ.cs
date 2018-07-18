using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class LuggageCompareMaxXYZ : IComparer<IBox>
    {
        public int Compare(IBox luggage_1, IBox luggage_2)
        {
            int luggage_1_value = max(luggage_1.getX(), luggage_1.getY(), luggage_1.getZ());
            int luggage_2_value = max(luggage_2.getX(), luggage_2.getY(), luggage_2.getZ());

            ComparerLogic evaluateWhichIsBigger = new ComparerLogic(luggage_1_value, luggage_2_value);
            int result = evaluateWhichIsBigger.compare();

            return result;
        }

        private int max(int input1, int input2)
        {
            int output = 0;

            if (input1 >= input2)
            {
                output = input1;
            }
            else
            {
                output = input2;
            }

            return output;
        }

        private int max(int input1, int input2, int input3)
        {
            int intermediateValue = 0;
            int output = 0;

            intermediateValue = max(input1, input2);
            output = max(intermediateValue, input3);

            return output;
        }
    }
}
