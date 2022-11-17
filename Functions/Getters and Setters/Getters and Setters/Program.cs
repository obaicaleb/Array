using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_Setters
{
    class Program
    {

        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG");
            Movie shrek = new Movie("Shrek", "Adae Adamson", "PG-14");
            //G, PG, PG-13, NR

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}
