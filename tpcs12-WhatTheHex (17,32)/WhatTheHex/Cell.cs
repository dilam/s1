using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WhatTheHex
{
    public class Cell : Button
    {
        public static Color colorDefault = Color.Gray;
        public static Color[] colorMouseHover = { Color.Pink, Color.Turquoise };
        public static Color[] colorMouseClick = { Color.Red, Color.Blue };

        public int visited = 0;
        private int owner = 0;
        private int x, y;

        #region Cell Constructor
        public Cell(int x, int y)
        {
            // Convert to hex grid
            this.x = x;
            this.y = y;
            HexGrid(ref x, ref y);
            this.Location = new Point(x, y);
            this.BackColor = Cell.colorDefault;

            // Make Hex Points
            int a = gameInfo.scale / 2;
            int b = (int)Math.Sqrt(3) * a * 2;
            int width = gameInfo.scale * 4;

            PointF[] tbp = {
                new PointF(width / 2 + -2 * a, width / 2 + 0 ),
                new PointF(width / 2 + -a    , width / 2 + b ),
                new PointF(width / 2 + a     , width / 2 + b ),
                new PointF(width / 2 + 2 * a , width / 2 + 0 ),
                new PointF(width / 2 + a     , width / 2 + -b),
                new PointF(width / 2 + -a    , width / 2 + -b)
            };

            // Handle Vertical mode
            if (!gameInfo.horizontal)
            {
                for (int i = 0; i < tbp.Length; i++)
                {
                    float tmp = tbp[i].X;
                    tbp[i].X = tbp[i].Y;
                    tbp[i].Y = tmp;
                }
            }

            // Events
            this.MouseEnter += new EventHandler(HexMouseEnter);
            this.MouseLeave += new EventHandler(HexMouseLeave);
            this.Click += new EventHandler(HexClick);

            // Points to GP
            GraphicsPath polygon_path = new GraphicsPath(FillMode.Winding);
            polygon_path.AddPolygon(tbp);

            // GP to the hex region.
            Region polygon_region = new Region(polygon_path);
            this.Region = polygon_region;

            // Bounds
            this.SetBounds(x, y, width, width);
        }
        #endregion

        public int getOwner()
        {
            return owner;
        }
        public int Value
        {
            get { return owner; }
            set { owner = value;
                if (value == 0)
                    this.BackColor = Cell.colorDefault;
                else
                    this.BackColor = Cell.colorMouseClick[value - 1];
            }
        }

        public void restart()
        {
            owner = 0;
            visited = 0;
            this.BackColor = Cell.colorDefault;
            gameInfo.debuged = !gameInfo.debuged;
            gameInfo.debugDisplay();
        }


        // ======== EVENTS 

        public void changeColor(Color c)
        {
            this.BackColor = c;
        }
        private void HexMouseEnter(object sender, EventArgs e)
        {
            if (gameInfo.board[x, y] == 0)
                changeColor(Cell.getColorMouseHover());
        }
        private void HexMouseLeave(object sender, EventArgs e)
        {
            if (gameInfo.board[x, y] == 0)
                changeColor(Cell.colorDefault);
        }
        private void HexClick(object sender, EventArgs e)
        {
            if (gameInfo.board[x, y] == 0)
                gameInfo.takeCell(gameInfo.currentPlayer, x, y);
        }

        public static Color getColorMouseClick()
        {
            return colorMouseClick[gameInfo.currentPlayer - 1];
        }

        public static Color getColorMouseHover()
        {
            return colorMouseHover[gameInfo.currentPlayer - 1];
        }

        // ======== Board making functions

        private void HexGrid(ref int x, ref int y)
        {
            int tx = (int)(gameInfo.start_x + (gameInfo.horizontal ? 1.5 : 1) *
                  (x + y) * (gameInfo.scale + gameInfo.grid_space));
            int ty = (int)(gameInfo.start_y + (gameInfo.horizontal ? 1 : 1.5) *
                  (x - y) * (gameInfo.scale + gameInfo.grid_space));
            x = tx;
            y = ty;
        }
    }
}
