using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySimCity
{
    class Building : House
    {
        // Attributes
        private int floors;

        // Constructor
        public Building(int rooms, int floors)
            :base(rooms)
        {
            this.rooms = rooms;
            this.floors = floors;
        }

        // Methods
        public override void Describe()
        {
            Console.WriteLine("Immeuble de " + floors + " étages et de " + rooms + " pièces.");
        }
        public override void WhoAmI()
        {
            Console.WriteLine("La classe \"Building\" est un immeuble et a pour propriété le nombre de pièce et d'étage.");
        }
    }
}
