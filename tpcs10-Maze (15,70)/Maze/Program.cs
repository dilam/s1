using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generation:");
            Maze m = new Maze(3, 2, 0, 0, 2, 1);
            m.generate(); m.display();

            Console.WriteLine("Pathfinding (parcours profondeur):");
            m.solve(); m.display();

            Console.ReadKey();
        }
    }
}
