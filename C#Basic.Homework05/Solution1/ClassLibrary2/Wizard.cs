using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Wizard
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PowerLevel { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public bool GraduationStatus { get; set; } = false;
        public Wizard(){}
        public Wizard(string name, int age, int powerlevel, DateTime dateofadmission, bool gradiationstatus)
        {
            Name = name;
            Age = age;
            PowerLevel = powerlevel;
            DateOfAdmission = dateofadmission;
            GraduationStatus = gradiationstatus;
        }
        public void Duel(Creature creature)
        {
            if (creature.Tamed)
            {
                Console.WriteLine($"The {creature.Name} is already tamed ");
            }
            else
            {
                if(PowerLevel > creature.PowerLevel)
                {
                    Console.WriteLine($"The wizzard: {Name} has won");
                }else if(PowerLevel < creature.PowerLevel)
                {
                    Console.WriteLine($"The creature: {creature.Name} has won");
                }
                else
                {
                    Console.WriteLine("They are equally strong");
                }
            }
        }
    }

}
