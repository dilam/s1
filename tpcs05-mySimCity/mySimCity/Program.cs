using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySimCity
{
    class Program
    {
        static void Main(string[] args)
        {
            City paris = new City("Paris");
            paris.AddHuman(new Male("Michel", 26));
            paris.AddHuman(new Female("Isabelle", 21));
            paris.AddHouse(new Building(3, 5));
            paris.AddHouse(new Tree());
            House h = new House(2);
            paris.AddHouse(h);
            paris.DestroyHouse(h);
            paris.Describe();
            Console.Read();
        }
    }
}
