using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WhatTheHex
{
    public partial class Board : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Board()
        {
            // Uncomment to open a console, making Console.WriteLine() usable.
            AllocConsole();

            InitializeComponent();
            gameInfo.makeBoard(this);
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            gameInfo.playAI();
        }
    }
}