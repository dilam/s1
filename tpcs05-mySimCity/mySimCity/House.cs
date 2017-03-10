using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySimCity
{
    class House
    {
        // Attributes
        protected int rooms;

        // Getters & Setters
        public int Rooms
        {
            get { return rooms; }
            private set { rooms = value; }
        }

        // Constructor
        public House(int rooms)
        {
            this.rooms = rooms;
        }

        // Methods
        public virtual void Describe()
        {
            Console.WriteLine("Maison de " + rooms + " pièces.");
        }
        public virtual void WhoAmI()
        {
            Console.WriteLine("La classe \"House\" est une maison et a pour propriété le nombre de pièce.");
        }
    }
}
