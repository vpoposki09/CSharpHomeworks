using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Creature
    {
        public string Name { get; set; }
        public int PowerLevel { get; set; }
        public int Age { get; set; }
        public bool Tamed { get; set; }
        public Creature(){ }
        public Creature(string name, int powerlevel, int age, bool tamed)
        {
            Name = name;
            PowerLevel = powerlevel;
            Age = age;
            Tamed = tamed;
        }


    }
}
