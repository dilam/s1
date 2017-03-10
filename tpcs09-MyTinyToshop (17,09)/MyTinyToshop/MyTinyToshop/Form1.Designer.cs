namespace MyTinyToshop
{
    partial class myTinyToshop
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myTinyToshop));
            this.menu = new System.Windows.Forms.ToolStrip();
            this.open = new System.Windows.Forms.ToolStripButton();
            this.ResetButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filters = new System.Windows.Forms.ToolStripDropDownButton();
            this.greyScale = new System.Windows.Forms.ToolStripMenuItem();
            this.binarize = new System.Windows.Forms.ToolStripMenuItem();
            this.negative = new System.Windows.Forms.ToolStripMenuItem();
            this.tinter = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchFlag = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvolutionMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.average = new System.Windows.Forms.ToolStripMenuItem();
            this.gauss = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpen = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeEnhance = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.emboss = new System.Windows.Forms.ToolStripMenuItem();
            this.geometricMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.mirrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalM = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalM = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftRot = new System.Windows.Forms.ToolStripMenuItem();
            this.RightRot = new System.Windows.Forms.ToolStripMenuItem();
            this.ConstrastStretch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorPicker = new System.Windows.Forms.ToolStripButton();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rainbowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.ResetButton,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.filters,
            this.ConvolutionMenu,
            this.geometricMenu,
            this.ConstrastStretch,
            this.toolStripSeparator2,
            this.colorPicker});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(531, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "toolStrip1";
            // 
            // open
            // 
            this.open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(40, 22);
            this.open.Text = "Open";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResetButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetButton.Image")));
            this.ResetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(39, 22);
            this.ResetButton.Text = "Reset";
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "Save";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // filters
            // 
            this.filters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyScale,
            this.binarize,
            this.negative,
            this.tinter,
            this.frenchFlag,
            this.rainbowToolStripMenuItem});
            this.filters.Image = ((System.Drawing.Image)(resources.GetObject("filters.Image")));
            this.filters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(46, 22);
            this.filters.Text = "Filter";
            // 
            // greyScale
            // 
            this.greyScale.Name = "greyScale";
            this.greyScale.Size = new System.Drawing.Size(152, 22);
            this.greyScale.Text = "Greyscale";
            this.greyScale.Click += new System.EventHandler(this.greyScale_Click);
            // 
            // binarize
            // 
            this.binarize.Name = "binarize";
            this.binarize.Size = new System.Drawing.Size(152, 22);
            this.binarize.Text = "Binarize";
            this.binarize.Click += new System.EventHandler(this.binarize_Click);
            // 
            // negative
            // 
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(152, 22);
            this.negative.Text = "Negative";
            this.negative.Click += new System.EventHandler(this.negative_Click);
            // 
            // tinter
            // 
            this.tinter.Name = "tinter";
            this.tinter.Size = new System.Drawing.Size(152, 22);
            this.tinter.Text = "Tinter";
            this.tinter.Click += new System.EventHandler(this.tinter_Click);
            // 
            // frenchFlag
            // 
            this.frenchFlag.Name = "frenchFlag";
            this.frenchFlag.Size = new System.Drawing.Size(152, 22);
            this.frenchFlag.Text = "FrenchFlag";
            this.frenchFlag.Click += new System.EventHandler(this.frenchFlag_Click);
            // 
            // ConvolutionMenu
            // 
            this.ConvolutionMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConvolutionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.average,
            this.gauss,
            this.sharpen,
            this.edgeEnhance,
            this.edgeDetect,
            this.emboss});
            this.ConvolutionMenu.Image = ((System.Drawing.Image)(resources.GetObject("ConvolutionMenu.Image")));
            this.ConvolutionMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConvolutionMenu.Name = "ConvolutionMenu";
            this.ConvolutionMenu.Size = new System.Drawing.Size(86, 22);
            this.ConvolutionMenu.Text = "Convolution";
            // 
            // average
            // 
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(148, 22);
            this.average.Text = "Average";
            this.average.Click += new System.EventHandler(this.average_Click);
            // 
            // gauss
            // 
            this.gauss.Name = "gauss";
            this.gauss.Size = new System.Drawing.Size(148, 22);
            this.gauss.Text = "Gauss";
            this.gauss.Click += new System.EventHandler(this.gauss_Click);
            // 
            // sharpen
            // 
            this.sharpen.Name = "sharpen";
            this.sharpen.Size = new System.Drawing.Size(148, 22);
            this.sharpen.Text = "Sharpen";
            this.sharpen.Click += new System.EventHandler(this.sharpen_Click);
            // 
            // edgeEnhance
            // 
            this.edgeEnhance.Name = "edgeEnhance";
            this.edgeEnhance.Size = new System.Drawing.Size(148, 22);
            this.edgeEnhance.Text = "Edge Enhance";
            this.edgeEnhance.Click += new System.EventHandler(this.edgeEnhance_Click);
            // 
            // edgeDetect
            // 
            this.edgeDetect.Name = "edgeDetect";
            this.edgeDetect.Size = new System.Drawing.Size(148, 22);
            this.edgeDetect.Text = "Edge Detect";
            this.edgeDetect.Click += new System.EventHandler(this.edgeDetect_Click);
            // 
            // emboss
            // 
            this.emboss.Name = "emboss";
            this.emboss.Size = new System.Drawing.Size(148, 22);
            this.emboss.Text = "Emboss";
            this.emboss.Click += new System.EventHandler(this.emboss_Click);
            // 
            // geometricMenu
            // 
            this.geometricMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.geometricMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mirrorToolStripMenuItem,
            this.rotationToolStripMenuItem});
            this.geometricMenu.Image = ((System.Drawing.Image)(resources.GetObject("geometricMenu.Image")));
            this.geometricMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.geometricMenu.Name = "geometricMenu";
            this.geometricMenu.Size = new System.Drawing.Size(75, 22);
            this.geometricMenu.Text = "Geometric";
            // 
            // mirrorToolStripMenuItem
            // 
            this.mirrorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HorizontalM,
            this.VerticalM});
            this.mirrorToolStripMenuItem.Name = "mirrorToolStripMenuItem";
            this.mirrorToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mirrorToolStripMenuItem.Text = "Mirror";
            // 
            // HorizontalM
            // 
            this.HorizontalM.Name = "HorizontalM";
            this.HorizontalM.Size = new System.Drawing.Size(129, 22);
            this.HorizontalM.Text = "Horizontal";
            this.HorizontalM.Click += new System.EventHandler(this.HorizontalM_Click);
            // 
            // VerticalM
            // 
            this.VerticalM.Name = "VerticalM";
            this.VerticalM.Size = new System.Drawing.Size(129, 22);
            this.VerticalM.Text = "Vertical";
            this.VerticalM.Click += new System.EventHandler(this.VerticalM_Click);
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LeftRot,
            this.RightRot});
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rotationToolStripMenuItem.Text = "Rotation";
            // 
            // LeftRot
            // 
            this.LeftRot.Name = "LeftRot";
            this.LeftRot.Size = new System.Drawing.Size(102, 22);
            this.LeftRot.Text = "Left";
            this.LeftRot.Click += new System.EventHandler(this.LeftRot_Click);
            // 
            // RightRot
            // 
            this.RightRot.Name = "RightRot";
            this.RightRot.Size = new System.Drawing.Size(102, 22);
            this.RightRot.Text = "Right";
            this.RightRot.Click += new System.EventHandler(this.RightRot_Click);
            // 
            // ConstrastStretch
            // 
            this.ConstrastStretch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConstrastStretch.Image = ((System.Drawing.Image)(resources.GetObject("ConstrastStretch.Image")));
            this.ConstrastStretch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConstrastStretch.Name = "ConstrastStretch";
            this.ConstrastStretch.Size = new System.Drawing.Size(85, 22);
            this.ConstrastStretch.Text = "Auto Contrast";
            this.ConstrastStretch.Click += new System.EventHandler(this.ConstrastStretch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // colorPicker
            // 
            this.colorPicker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.colorPicker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(40, 22);
            this.colorPicker.Text = "Color";
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 281);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(467, 2);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown.TabIndex = 2;
            this.numericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // rainbowToolStripMenuItem
            // 
            this.rainbowToolStripMenuItem.Name = "rainbowToolStripMenuItem";
            this.rainbowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rainbowToolStripMenuItem.Text = "Rainbow";
            this.rainbowToolStripMenuItem.Click += new System.EventHandler(this.rainbowToolStripMenuItem_Click);
            // 
            // myTinyToshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(531, 320);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menu);
            this.Name = "myTinyToshop";
            this.Text = "MyTinyToshop";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton ResetButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton filters;
        private System.Windows.Forms.ToolStripMenuItem greyScale;
        private System.Windows.Forms.ToolStripMenuItem binarize;
        private System.Windows.Forms.ToolStripMenuItem negative;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripButton colorPicker;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem tinter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton ConvolutionMenu;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ToolStripButton open;
        private System.Windows.Forms.ToolStripMenuItem frenchFlag;
        private System.Windows.Forms.ToolStripMenuItem average;
        private System.Windows.Forms.ToolStripMenuItem gauss;
        private System.Windows.Forms.ToolStripMenuItem sharpen;
        private System.Windows.Forms.ToolStripMenuItem edgeEnhance;
        private System.Windows.Forms.ToolStripMenuItem edgeDetect;
        private System.Windows.Forms.ToolStripMenuItem emboss;
        private System.Windows.Forms.ToolStripButton ConstrastStretch;
        private System.Windows.Forms.ToolStripDropDownButton geometricMenu;
        private System.Windows.Forms.ToolStripMenuItem mirrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HorizontalM;
        private System.Windows.Forms.ToolStripMenuItem VerticalM;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LeftRot;
        private System.Windows.Forms.ToolStripMenuItem RightRot;
        private System.Windows.Forms.ToolStripMenuItem rainbowToolStripMenuItem;
    }
}

