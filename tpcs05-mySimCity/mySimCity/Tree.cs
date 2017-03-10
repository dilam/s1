using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySimCity
{
    class Tree : House
    {
        // Constructor
        public Tree()
            :base(0)
        {
        }

        // Methods
        public override void Describe()
        {
            Console.WriteLine("Je suis un aaaarrbree!!!");
        }
        public override void WhoAmI()
        {
            Console.WriteLine("La classe \"Tree\" est un arbre et n'a pas de propriété.");
        }
    }
}
