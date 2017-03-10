namespace WhatTheHex
{
    partial class Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.buttonRestart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.azeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readTheSubjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.askAnACDCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.neverGonnaGiveYouUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRestart
            // 
            this.buttonRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonRestart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(61, 22);
            this.buttonRestart.Text = "RESTART";
            this.buttonRestart.ToolTipText = "Prepare for the battle.";
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azeToolStripMenuItem,
            this.aToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripDropDownButton1.Text = "Subject";
            // 
            // azeToolStripMenuItem
            // 
            this.azeToolStripMenuItem.Name = "azeToolStripMenuItem";
            this.azeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.azeToolStripMenuItem.Text = "Display coordinates";
            this.azeToolStripMenuItem.Click += new System.EventHandler(this.azeToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readTheSubjectToolStripMenuItem1,
            this.askAnACDCToolStripMenuItem1,
            this.toolStripMenuItem3});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aToolStripMenuItem.Text = "Help";
            // 
            // readTheSubjectToolStripMenuItem1
            // 
            this.readTheSubjectToolStripMenuItem1.Name = "readTheSubjectToolStripMenuItem1";
            this.readTheSubjectToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.readTheSubjectToolStripMenuItem1.Text = "Read the subject";
            // 
            // askAnACDCToolStripMenuItem1
            // 
            this.askAnACDCToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neverGonnaGiveYouUpToolStripMenuItem});
            this.askAnACDCToolStripMenuItem1.Name = "askAnACDCToolStripMenuItem1";
            this.askAnACDCToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.askAnACDCToolStripMenuItem1.Text = "Ask an ACDC";
            // 
            // neverGonnaGiveYouUpToolStripMenuItem
            // 
            this.neverGonnaGiveYouUpToolStripMenuItem.Name = "neverGonnaGiveYouUpToolStripMenuItem";
            this.neverGonnaGiveYouUpToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.neverGonnaGiveYouUpToolStripMenuItem.Text = "Never Gonna Give You Up";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem3.Text = "42";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonRestart,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Play with AI";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 136);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatTheHex";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            gameInfo.winForm = this;
        }
        private void buttonRestart_Click(object sender, System.EventArgs e)
        {
            gameInfo.restart();
        }

        private void azeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            gameInfo.debugDisplay();
        }
        #endregion

        private System.Windows.Forms.ToolStripButton buttonRestart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem azeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readTheSubjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem askAnACDCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem neverGonnaGiveYouUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

