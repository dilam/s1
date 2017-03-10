using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void strings_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            new Output(Strings.strings(openFileDialog1.FileName)).Show();
        }

        private void split_button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select a folder";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        Splitter.split(openFileDialog1.FileName, dlg.SelectedPath, 9);
                }
            }
        }

        private void merge_button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select a folder";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        Splitter.merge(saveFileDialog1.FileName, dlg.SelectedPath, 9);
                }
            }
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                Stegano.hide(openFileDialog1.FileName, richTextBox1.Text);
        }

        private void reveal_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                new Output(Stegano.reveal(openFileDialog1.FileName)).Show();
        }
    }
}
