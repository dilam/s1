using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySimCity
{
    class Male : Human
    {
        // Constructor
        public Male(string name, int age)
            : base(name,age)
        {
            this.name = name;
            this.age = age;
        }
        // Methods
        public override void Describe()
        {
            Console.WriteLine(name + ", " + age + " ans (homme).");
        }
        public override void WhoAmI()
        {
            Console.WriteLine("La classe \"Male\" est un homme et a pour propriété le prénom et l'âge.");
        }
    }
}
