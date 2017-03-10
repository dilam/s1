using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck
{
    public class Tree
    {
        Tree left_;
        Tree right_;
        int frequency_;
        char c_;

        public Tree(Tree left, Tree right, int frequency, char c)
        {
            this.left_ = left;
            this.right_ = right;
            this.frequency_ = frequency;
            this.c_ = c;
        }

        public int GetFrequency()
        {
            return frequency_;
        }

        public Tree Left()
        {
            return left_;
        }

        public Tree Right()
        {
            return right_;
        }

        public char Symbole()
        {
            return c_;
        }
    }
}
