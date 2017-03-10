using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{



    class Maze
    {
        private uint width; //Width of the maze
        private uint height; //Height of the maze
        private Cell[,] maze; //Array (dimension 2) which contains all ths cells
        private Tuple<uint, uint> posStart; //The position (x, y) of the start
        private Tuple<uint, uint> posEnd; //The position (x, y) of the start
        private Random rand; //A random number generator

        public Maze(uint width, uint height, uint xStart, uint yStart, uint xEnd, uint yEnd)
        {
            rand = new Random();
            this.width = width;
            this.height = height;
            this.maze = new Cell[width, height];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    maze[i, j] = new Cell(Type.NONE);
            maze[xStart, yStart] = new Cell(Type.START);
            maze[xEnd, yEnd] = new Cell(Type.END);
            posStart = new Tuple<uint, uint>(xStart, yStart);
            posEnd = new Tuple<uint, uint>(xEnd, yEnd);
        }

        #region Display
        private string verticalWall(uint x1, uint x2, uint y)
        {
            bool b = false;
            Tuple<uint, uint> pos = new Tuple<uint, uint>(x2, y);
            List<Tuple<uint, uint>> isLink = maze[x1, y].getLinkedList();
            int l = isLink.Count;
            int i = 0;

            while (i < l && !b)
            {
                b = pos == isLink[i];
                i++;
            }

            return (x1 > 0 && x1 < width - 1 && x2 > 0 && x2 < width - 1 && y >= 0 && y < height && b) ? " " : "|";
        }

        private string horizontalWall(uint x, uint y1, uint y2)
        {
            bool b = false;
            Tuple<uint, uint> pos = new Tuple<uint, uint>(x, y2);
            List<Tuple<uint, uint>> isLink = maze[x, y1].getLinkedList();
            int l = isLink.Count;
            int i = 0;

            while (i < l && !b)
            {
                b = pos == isLink[i];
                i++;
            }

            return (y1 > 0 && y1 < height - 1 && y2 > 0 && y2 < height - 1 && x >= 0 && x < height && b) ? "  " : "--";
        }

        public void display()
        {
            string sep = "+";
            for (int i = 0; i < width; i++)
            {
                sep = sep + "--+";
            }

            Console.WriteLine(sep);

            for (uint i = 0; i < height - 1; i++)
            {
                Console.Write("|");
                for (uint j = 0; j < width - 1; j++)
                {
                    Console.Write(maze[j, i].display());
                    Console.Write(verticalWall(j, j + 1, i));
                }
                Console.Write(maze[width - 1, i].display());
                Console.WriteLine("|");
                
                for (uint j = 0; j < width; j++)
                {
                    Console.Write("+");
                    Console.Write(horizontalWall(j, i, i+1));
                }
                Console.WriteLine("+");
            }

            Console.Write("|");
            for (uint j = 0; j < width - 1; j++)
            {
                Console.Write(maze[j, height - 1].display());
                Console.Write(verticalWall(j, j + 1, height - 1));
            }
            Console.Write(maze[width - 1, height - 1].display());
            Console.WriteLine("|");

            Console.WriteLine(sep);
        }
        #endregion


        #region Generation
        private List<Tuple<uint, uint>> getNotVisitedNeighbor(uint x, uint y)
        {
            List<Tuple<uint, uint>> n = new List<Tuple<uint, uint>>();

            if (x != width - 1)
                if (maze[x + 1, y].getVisited() == false)
                    n.Add(Tuple.Create(x + 1, y));
            if (x != 0)
                if (maze[x - 1, y].getVisited() == false)
                    n.Add(Tuple.Create(x - 1, y));
            if (y != height - 1)
                if (maze[x, y + 1].getVisited() == false)
                    n.Add(Tuple.Create(x, y + 1));
            if (y != 0)
                if (maze[x, y - 1].getVisited() == false)
                    n.Add(Tuple.Create(x, y - 1));

            return n;
        }
        public void generate()
        {
            uint cx = (uint)rand.Next((int)width);
            uint cy = (uint)rand.Next((int)height);

            generateRec(cx, cy);
        }
        private void generateRec(uint x, uint y)
        {
            maze[x, y].setVisited(true);
            List<Tuple<uint, uint>> notVisit = getNotVisitedNeighbor(x, y);
            int l = notVisit.Count;
            if (l > 0)
            {
                int i = rand.Next(0, l);
                maze[x, y].addLink(notVisit[i]);
                maze[notVisit[i].Item1, notVisit[i].Item2].addLink(new Tuple<uint, uint>(x , y));
                generateRec(notVisit[i].Item1, notVisit[i].Item2);
            }
        }

        #endregion


        #region Solve
        private void cleanVisited()
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    maze[x, y].setVisited(false);
        }

        public void solve()
        {
            cleanVisited();
            solveRec(posStart.Item1, posStart.Item2);
        }

        private bool solveRec(uint x, uint y)
        {
            List<Tuple<uint, uint>> notVisit = getNotVisitedNeighbor(x, y);
            int l = notVisit.Count;
            if (l > 0)
            {
                int i = rand.Next(0, l);
                uint x2 = notVisit[i].Item1;
                uint y2 = notVisit[i].Item2;

                maze[x2, y2].setVisited(true);

                if (maze[x2, y2].getType() == Type.END)
                {
                    return true;
                }
                else
                {
                    if (getNotVisitedNeighbor(x2, y2).Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if (solveRec(x2, y2) == true)
                        {
                            maze[x, y].setType(Type.PATH);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }
        #endregion



    }
}
