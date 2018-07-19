#undef DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerBagaznika
{
    class Program
    {
        static LuggageList listaBagazy = new LuggageList();

        static void Main(string[] args)
        {
            Console.WriteLine("Organizer bagaznika. Wesja 1.0");
            Console.WriteLine("******************************\n");

            Trunk bagaznik = new Trunk(50, 50, 50);

            Console.WriteLine("Bagaznik: {0}\n", bagaznik);

            listaBagazy.addLuggage(new Suitcase(24, 26, 26));
            listaBagazy.addLuggage(new Suitcase(24, 26, 26));

            DebugSupporter.printPropertyValue(nameof(listaBagazy), listaBagazy);
            DebugSupporter.printPropertyValue("listaBagazy.getLength()", listaBagazy.getLength());

            /*
                        listaBagazy.addLuggage(new Suitcase(10, 50, 70));
                        listaBagazy.addLuggage(new Suitcase(20, 30, 40));
                        listaBagazy.addLuggage(new Suitcase(99, 12, 17));
                        listaBagazy.addLuggage(new Suitcase(51, 14, 13));
                        listaBagazy.addLuggage(new Suitcase(71, 18, 98));
                        listaBagazy.addLuggage(new Suitcase(99, 12, 17));
                        listaBagazy.addLuggage(new Suitcase(51, 99, 13));
                        listaBagazy.addLuggage(new Suitcase(71, 18, 99));
                        */

            LuggageCalc optymalizatorBagaznika = new LuggageCalc(listaBagazy, bagaznik);

            Console.WriteLine("Lista nieposortowana:");
            Console.WriteLine("******************************\n");
            Console.WriteLine(listaBagazy);
       }

        static int getInput(string dimension)
        {
            int dim = 0;
            Console.Write("Podaj wymiar {0} bagazu: ", dimension);
            dim = Convert.ToInt16(Console.ReadLine());

            return dim;
        }

        static void testSortowania()
        {
            Console.WriteLine("Lista posortowana po objetosci:");
            Console.WriteLine("******************************\n");
            listaBagazy.sortVolume();
            Console.WriteLine(listaBagazy);

            Console.WriteLine("Lista posortowana po wymiarze X:");
            Console.WriteLine("******************************\n");
            listaBagazy.sortX();
            Console.WriteLine(listaBagazy);

            Console.WriteLine("Lista posortowana po wymiarze Y:");
            Console.WriteLine("******************************\n");
            listaBagazy.sortY();
            Console.WriteLine(listaBagazy);

            Console.WriteLine("Lista posortowana po wymiarze Z:");
            Console.WriteLine("******************************\n");
            listaBagazy.sortZ();
            Console.WriteLine(listaBagazy);

            Console.WriteLine("Lista posortowana po wymiarze max(XYZ):");
            Console.WriteLine("******************************\n");
            listaBagazy.sortMaxXYZ();
            Console.WriteLine(listaBagazy);
        }
    }
}
