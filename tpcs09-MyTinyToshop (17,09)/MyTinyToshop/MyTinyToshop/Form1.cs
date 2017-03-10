using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTinyToshop
{
    public partial class myTinyToshop : Form
    {
        public myTinyToshop()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
                pictureBox.Image = Image.FromFile(openDialog.FileName);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
                pictureBox.Image.Save(saveDialog.FileName, ImageFormat.Png);
        }

        private void greyScale_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.MapPixels((Bitmap)pictureBox.Image, Filters.Greyscale);
        }

        private void binarize_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.MapPixels((Bitmap)pictureBox.Image, Filters.Binarize);
        }

        private void negative_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Filters.MapPixels((Bitmap)pictureBox.Image, Filters.Negative);
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void tinter_Click(object sender, EventArgs e)
        {
            Filters.Tint = colorDialog1.Color;
            Filters.Coef = (int)numericUpDown.Value;
            pictureBox.Image = Filters.MapPixels((Bitmap)pictureBox.Image, Filters.Tinter);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = MyTinyToshop.Properties.Resources.Perry;
        }

        private void frenchFlag_Click(object sender, EventArgs e)
        {
            Filters.Coef = (int)numericUpDown.Value;
            Color[] colors = { Color.Blue, Color.White, Color.Red };

            pictureBox.Image = Filters.Stripes((Bitmap)pictureBox.Image, colors);
        }

        private void average_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Convolution.Convolute((Bitmap)pictureBox.Image, Convolution.AverageMask);
        }

        private void gauss_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Convolution.Convolute((Bitmap)pictureBox.Image, Convolution.GaussMask);
        }

        private void sharpen_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Convolution.Convolute((Bitmap)pictureBox.Image, Convolution.SharpenMask);
        }

        private void edgeEnhance_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Convolution.Convolute((Bitmap)pictureBox.Image, Convolution.EdgeEnhanceMask);
        }

        private void edgeDetect_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Convolution.Convolute((Bitmap)pictureBox.Image, Convolution.EdgeDetectMask);
        }

        private void emboss_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Convolution.Convolute((Bitmap)pictureBox.Image, Convolution.EmbossMask);
        }

        private void ConstrastStretch_Click(object sender, EventArgs e)
        {
            pictureBox.Image = ContrastStretch.ConstrastStretch((Bitmap)pictureBox.Image);
        }

        private void HorizontalM_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Geometric.HorizontalMirror((Bitmap)pictureBox.Image);
        }

        private void VerticalM_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Geometric.VerticalMirror((Bitmap)pictureBox.Image);
        }

        private void LeftRot_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Geometric.LeftRotation((Bitmap)pictureBox.Image);
        }

        private void RightRot_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Geometric.RightRotation((Bitmap)pictureBox.Image);
        }

        private void rainbowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters.Coef = (int)numericUpDown.Value;
            Color[] colors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Purple };

            pictureBox.Image = Filters.Stripes((Bitmap)pictureBox.Image, colors);
        }
    }
}
