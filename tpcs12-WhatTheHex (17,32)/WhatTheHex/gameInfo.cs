using System;
using System.Drawing;
using System.Windows.Forms;

namespace WhatTheHex
{
	public static class gameInfo
	{
		public enum player
		{
			HUMAN,
			AI
		};

		public static Cell[,] cells;
		public static int[,] board;

		// ============== Board settings
		public static Board winForm;
		public static int scale = 27;
		public static bool horizontal = true;

		public static int grid_space = 2;
		public static int row = 6;
		public static int column = row;
		public static int start_x = 0;
		public static int start_y = (int)(column * scale * (horizontal ? 1.1 : 1.5));

        // ============== Current session
        public static int currentPlayer = 1;
		public static player[] players = { player.HUMAN, player.HUMAN };

        // Change this variable when the game is finished
		public static bool finished = false;

        // Useful for isFinished()
		private static int currentVisit = 0;

		public static AI[] HAL = {new AI(1), new AI(2)};
		public static bool debuged = false;
		public static void playAI()
		{
			Tuple<int, int> play = HAL[currentPlayer - 1].play(board);
			takeCell(currentPlayer, play.Item1, play.Item2);
		}

        public static bool isPlayFinishedRec(int x, int y, int player, int[,] board)
        {
            if (x < 0 || x >= row || y < 0 || y >= column || cells[x, y].visited == currentVisit || board[x, y] != player)
                return false;

            cells[x, y].visited = currentVisit;

            if ((player == 1 && y == column - 1) || (player == 2 && x == row - 1))
                return true;

            if (isPlayFinishedRec(x, y - 1, player, board) || isPlayFinishedRec(x - 1, y + 1, player, board) || isPlayFinishedRec(x + 1, y, player, board) ||
                isPlayFinishedRec(x - 1, y, player, board) || isPlayFinishedRec(x + 1, y - 1, player, board) || isPlayFinishedRec(x, y + 1, player, board))
                return true;

            return false;
        }
        public static bool isPlayFinished(int player, int[,] board)
        {
            currentVisit += 1;
            int endLoop = (player == 1 ? row : column);

            for (int i = 0; i < endLoop; i++)
            {
                if (isPlayFinishedRec(player == 1 ? i : 0, player == 2 ? i : 0, player, board))
                    return true;
            }

            return false;
        }
        public static int isFinished(int[,] board)
        {
            if (isPlayFinished(1, board))
                return 1;

            else if (isPlayFinished(2, board))
                return 2;

            return 0;
        }

        // ============== GAME

        // That function is linked to the winform menu 'Subject'
        public static void debugDisplay()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (debuged)
                        cells[i, j].Text = "";
                    else
                        cells[i, j].Text = i.ToString() + ":" + j.ToString();
                }
            }
            debuged = !debuged;
        }

        public static void makeBoard(Board form)
		{
			// Create Hexatons
			cells = new Cell[row, column];
			board = new int[row, column];
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					cells[i, j] = new Cell(i, j);
					board[i, j] = 0;
					form.Controls.Add(cells[i, j]);
				}
			}

			// Set Size
			form.Size = new Size(
				cells[row - 1, column - 1].Location.X + scale * 5,
				cells[row - 1, 0].Location.Y + scale * 6);

			// Anchors, allowing resizing
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					cells[i, j].Anchor = AnchorStyles.Bottom & AnchorStyles.Right;
				}
			}
		}

		public static void restart()
		{
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					cells[i, j].restart();
					board[i, j] = 0;
				}
			}
			winForm.ResetBackColor();
			currentPlayer = 1;
			finished = false;
		}

		public static void takeCell(int player, int x, int y)
		{
			if (!finished)
			{
				board[x, y] = player;
				cells[x, y].changeColor(Cell.getColorMouseClick());
				finished = isFinished(gameInfo.board) != 0;
				if (finished)
					changeWinColor(currentPlayer);
				currentPlayer = currentPlayer % 2 + 1;
			}
		}

		private static void changeWinColor(int player)
		{
			winForm.BackColor = Cell.getColorMouseHover();
        }
	}
}
