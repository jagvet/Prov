using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            book a1 = new book();//hämtar klassen

            a1.PrintInfo();//skriver ut PrintInfo från klassen
            

            Console.ReadLine();
        }
    }
}
