using System;

namespace WhatTheHex
{
	using typeElement = Tuple<float, Tuple<int, int>>;

	public class AI
	{
        int max_games_analysed = 150;
		int max_depth = 2;
		int color;
		Random rand;

		public AI(int color)
		{
            rand = new Random();
            this.color = color;
        }

		public AI(int color, int max_games_analysed, int max_depth) : this(color)
		{
            rand = new Random();
            this.color = color;
            this.max_games_analysed = max_games_analysed;
            this.max_depth = max_depth;
		}
        
		public typeElement minimax(Tree<typeElement> tree, int depth)
		{
            if (depth == max_depth)
                return tree.Node;

            if (depth == 0)
            {
                typeElement bestAI = new typeElement(0, new Tuple<int, int>(0, 0));

                for (int i = 0; i < tree.nbChild(); i++)
                {
                    if (bestAI.Item1 < minimax(tree.getChild(i), depth++).Item1)
                       bestAI = minimax(tree.getChild(i), depth++);
                }

                return bestAI;
            }
            else
            {
                typeElement bestP = new typeElement(0, new Tuple<int, int>(0, 0));

                for (int i = 0; i > tree.nbChild(); i++)
                {
                    if (bestP.Item1 < minimax(tree.getChild(i), depth++).Item1)
                        bestP = minimax(tree.getChild(i), depth++);
                }

                return bestP;
            }
		}

        void build_tree(Tree<typeElement> tree, int[,] board, int depth)
        {
            if (depth == max_depth)
                monteCarlo(board, color);

            else
            {
                for (int i = 0; i < gameInfo.row; i++)
                {
                    for (int j = 0; j < gameInfo.column; j++)
                    {
                        board[i, j] = color;
                        Tuple<int, int> pos = new Tuple<int, int>(i, j);
                        Tree<typeElement> child = new Tree<typeElement>(new typeElement(0, pos));
                        tree.addChild(child);
                        build_tree(tree.getChild(tree.nbChild() - 1), board, depth++);
                        board[i, j] = 0;
                    }
                }
            }

        }

        float monteCarlo(int[,] board, int color)
        {
            int[,] test;
            float rnd;

            do
            {
                test = board;
                rnd = rand.Next(gameInfo.row * gameInfo.column);
            } while (test[(int)rnd / gameInfo.column, (int)rnd % gameInfo.row] != 0);

            return rnd;
        }

        public Tuple<int, int> play(int[,] board)
		{
            Tree<typeElement> tree = new Tree<typeElement>(new typeElement(0, new Tuple<int, int>(0, 0)));
            build_tree(tree, board, 0);
            return minimax(tree, 0).Item2;
        }
	}
}
