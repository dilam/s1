using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySimCity
{
    class Female : Human
    {
        // Constructor
        public Female(string name, int age)
            : base(name,age)
        {
            this.name = name;
            this.age = age;
        }
        // Methods
        public override void Describe()
        {
            Console.WriteLine(name + ", " + age + " ans (femme).");
        }
        public override void WhoAmI()
        {
            Console.WriteLine("La classe \"Female\" est une femme et a pour propriété le prénom et l'âge.");
        }
    }
}
