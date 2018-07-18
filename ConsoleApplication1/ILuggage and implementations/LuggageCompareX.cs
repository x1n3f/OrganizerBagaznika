using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class LuggageCompareX : IComparer<ILuggage>
    {
        public int Compare(ILuggage luggage_1, ILuggage luggage_2)
        {
            int luggage_1_value = luggage_1.getX();
            int luggage_2_value = luggage_2.getX();

            ComparerLogic evaluateWhichIsBigger = new ComparerLogic(luggage_1_value, luggage_2_value);
            int result = evaluateWhichIsBigger.compare();

            return result;
        }
    }
}
