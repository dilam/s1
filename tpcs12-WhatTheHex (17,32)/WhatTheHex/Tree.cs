using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatTheHex
{
    public class Tree<Element>
    {
        private List<Tree<Element>> children;
        private Element node;

        public Tree (Element node)
        {
            this.node = node;
            children = new List<Tree<Element>>();
        }

        public Element Node
        {
            get { return node; }
            private set { node = value; }
        }

        public void addChild(Tree<Element> child)
        {
            children.Add(child);
        }

        public Tree<Element> getChild(int i)
        {
            return children.ElementAt(i);
        } 

        public int nbChild()
        {
            return children.Count;
        }

        public void print(Tree<Element> T, string parent = "")
        {
            int n = T.nbChild();
            
            if (n == 0)
                Console.Write("<");
            Console.Write(parent);
            Console.Write(T.node);

            for (int i = 0; i < n; i++)
                print(T.getChild(i), parent + T.Node + ".");

            if (n == 0)
                Console.Write(", ");
            else
                Console.Write(">");
        }
    }
}
