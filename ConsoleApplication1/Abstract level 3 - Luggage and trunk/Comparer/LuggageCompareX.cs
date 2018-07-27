using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class LuggageCompareX : IComparer<IContainer>
    {
        public int Compare(IContainer luggage_1, IContainer luggage_2)
        {
            int luggage_1_value = luggage_1.getDimX();
            int luggage_2_value = luggage_2.getDimX();

            ComparerLogic evaluateWhichIsBigger = new ComparerLogic(luggage_1_value, luggage_2_value);
            int result = evaluateWhichIsBigger.compare();

            return result;
        }
    }
}
