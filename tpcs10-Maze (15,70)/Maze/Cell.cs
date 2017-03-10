using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    enum Type
    {
        START, //The start of the maze
        END, //The end of the maze
        PATH, //For the cells which belong to the path once the maze solved
        NONE //Default type
    };

    class Cell
    {

        private List<Tuple<uint, uint>> linked; //Contains the list of the position of the cells which are linked with this cell
        private Type type; //The type of the cell
        private bool visited; //Store if the cell was visited

        public Cell(Type type = Type.NONE)
        {
            this.type = type;
            linked = new List<Tuple<uint, uint>>();
            visited = false;
        }

        #region Initialization
        public void setType(Type t)
        {
            type = t;
        }

        public Type getType()
        {
            return type;
        }

        public List<Tuple<uint, uint>> getLinkedList()
        {
            return linked;
        }


        public void setVisited(bool b)
        {
            visited = b;
        }

        public bool getVisited()
        {
            return visited;
        }
        #endregion


        #region Display
        public string display()
        {
            return (type == Type.START) ? "SS" : (type == Type.END) ? "EE" : (type == Type.PATH) ? "XX" : "  ";
        }
        #endregion


        #region Generation
        public void addLink(Tuple<uint, uint> posToLink)
        {
            linked.Add(posToLink);
        }

        public bool isLinked(uint x, uint y)
        {
            Tuple<uint, uint> pos = new Tuple<uint, uint>(x, y);
            return linked.Contains(pos);
        }
        #endregion

        #region Solve
        public void isPath()
        {
            if (type == Type.NONE)
                type = Type.PATH;
        }
        #endregion


    }
}
