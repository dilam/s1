using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySimCity
{
    class City
    {
        // Attributes
        private string name;
        private List<Human> people = new List<Human>();
        private List<House> building = new List<House>();

        // Getters & Setters
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        // Constructor
        public City(string name)
        {
            this.name = name;
        }

        // Methods
        public void AddHuman(Human h)
        {
            people.Add(h);
        }
        public void AddHouse(House h)
        {
            building.Add(h);
        }
        public void KillHuman(Human h)
        {
            people.Remove(h);
        }
        public void DestroyHouse(House h)
        {
            building.Remove(h);
        }
        public void Meteor()
        {
            people.Clear();
            building.Clear();
        }
        public virtual void Describe()
        {
            int cp = people.Count;
            int cb = building.Count;

            Console.WriteLine("Ville de " + name); // Nom

            Console.Write(cp); // Nb habitant
            if (cp > 1) { Console.WriteLine(" habitants :"); }
            else { Console.WriteLine(" habitant :"); }

            foreach (Human h in people) // Listes habitants
            {
                Console.Write("* ");
                h.Describe();
            }

            Console.Write(cb); // Nb maison
            if (cb > 1) { Console.WriteLine(" maisons :"); }
            else { Console.WriteLine(" maison :"); }

            foreach (House h in building) // Listes maisons
            {
                Console.Write("* ");
                h.Describe();
            }
        }
        public virtual void WhoAmI()
        {
            Console.WriteLine("La classe \"City\" est une ville et a pour propriété le nom.");
        }
    }
}
