using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard vlade = new Wizard("Vlatce", 26, 20, new DateTime(2018, 10, 15), false);
            Creature deki = new Creature("Dejan", 25, 27, false);

            vlade.Duel(deki);
            Console.ReadLine();
        }
    }
}
