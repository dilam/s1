namespace Tpcs07
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.leftPony = new System.Windows.Forms.PictureBox();
            this.rightPony = new System.Windows.Forms.PictureBox();
            this.rightLife = new System.Windows.Forms.ProgressBar();
            this.rightName = new System.Windows.Forms.Label();
            this.rightPV = new System.Windows.Forms.Label();
            this.leftPV = new System.Windows.Forms.Label();
            this.leftName = new System.Windows.Forms.Label();
            this.leftLife = new System.Windows.Forms.ProgressBar();
            this.leftAttack = new System.Windows.Forms.ComboBox();
            this.rightAttack = new System.Windows.Forms.ComboBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftPony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPony)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPony
            // 
            this.leftPony.BackColor = System.Drawing.Color.Transparent;
            this.leftPony.Location = new System.Drawing.Point(12, 77);
            this.leftPony.Name = "leftPony";
            this.leftPony.Size = new System.Drawing.Size(293, 435);
            this.leftPony.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftPony.TabIndex = 0;
            this.leftPony.TabStop = false;
            // 
            // rightPony
            // 
            this.rightPony.BackColor = System.Drawing.Color.Transparent;
            this.rightPony.Location = new System.Drawing.Point(638, 12);
            this.rightPony.Name = "rightPony";
            this.rightPony.Size = new System.Drawing.Size(293, 435);
            this.rightPony.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightPony.TabIndex = 1;
            this.rightPony.TabStop = false;
            // 
            // rightLife
            // 
            this.rightLife.Location = new System.Drawing.Point(638, 502);
            this.rightLife.Name = "rightLife";
            this.rightLife.Size = new System.Drawing.Size(293, 10);
            this.rightLife.TabIndex = 2;
            // 
            // rightName
            // 
            this.rightName.AutoSize = true;
            this.rightName.BackColor = System.Drawing.Color.Transparent;
            this.rightName.ForeColor = System.Drawing.Color.Red;
            this.rightName.Location = new System.Drawing.Point(635, 459);
            this.rightName.Name = "rightName";
            this.rightName.Size = new System.Drawing.Size(33, 13);
            this.rightName.TabIndex = 3;
            this.rightName.Text = "name";
            // 
            // rightPV
            // 
            this.rightPV.AutoSize = true;
            this.rightPV.Location = new System.Drawing.Point(753, 483);
            this.rightPV.Name = "rightPV";
            this.rightPV.Size = new System.Drawing.Size(62, 13);
            this.rightPV.TabIndex = 4;
            this.rightPV.Text = "pv / pvMax";
            // 
            // leftPV
            // 
            this.leftPV.AutoSize = true;
            this.leftPV.Location = new System.Drawing.Point(127, 42);
            this.leftPV.Name = "leftPV";
            this.leftPV.Size = new System.Drawing.Size(62, 13);
            this.leftPV.TabIndex = 7;
            this.leftPV.Text = "pv / pvMax";
            // 
            // leftName
            // 
            this.leftName.AutoSize = true;
            this.leftName.BackColor = System.Drawing.Color.Transparent;
            this.leftName.ForeColor = System.Drawing.Color.Red;
            this.leftName.Location = new System.Drawing.Point(9, 18);
            this.leftName.Name = "leftName";
            this.leftName.Size = new System.Drawing.Size(33, 13);
            this.leftName.TabIndex = 6;
            this.leftName.Text = "name";
            // 
            // leftLife
            // 
            this.leftLife.Location = new System.Drawing.Point(12, 61);
            this.leftLife.Name = "leftLife";
            this.leftLife.Size = new System.Drawing.Size(293, 10);
            this.leftLife.TabIndex = 5;
            // 
            // leftAttack
            // 
            this.leftAttack.FormattingEnabled = true;
            this.leftAttack.Location = new System.Drawing.Point(147, 10);
            this.leftAttack.Name = "leftAttack";
            this.leftAttack.Size = new System.Drawing.Size(158, 21);
            this.leftAttack.TabIndex = 8;
            this.leftAttack.Text = "list of attacks";
            // 
            // rightAttack
            // 
            this.rightAttack.FormattingEnabled = true;
            this.rightAttack.Location = new System.Drawing.Point(773, 459);
            this.rightAttack.Name = "rightAttack";
            this.rightAttack.Size = new System.Drawing.Size(158, 21);
            this.rightAttack.TabIndex = 9;
            this.rightAttack.Text = "list of attacks";
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(107, 8);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(34, 23);
            this.leftButton.TabIndex = 10;
            this.leftButton.Text = "GO";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(733, 459);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(34, 23);
            this.rightButton.TabIndex = 11;
            this.rightButton.Text = "GO";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 524);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightAttack);
            this.Controls.Add(this.leftAttack);
            this.Controls.Add(this.leftPV);
            this.Controls.Add(this.leftName);
            this.Controls.Add(this.leftLife);
            this.Controls.Add(this.rightPV);
            this.Controls.Add(this.rightName);
            this.Controls.Add(this.rightLife);
            this.Controls.Add(this.rightPony);
            this.Controls.Add(this.leftPony);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Get ready to Rumble !";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leftPony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPony)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox leftPony;
        private System.Windows.Forms.PictureBox rightPony;
        private System.Windows.Forms.ProgressBar rightLife;
        private System.Windows.Forms.Label rightName;
        private System.Windows.Forms.Label rightPV;
        private System.Windows.Forms.Label leftPV;
        private System.Windows.Forms.Label leftName;
        private System.Windows.Forms.ProgressBar leftLife;
        private System.Windows.Forms.ComboBox leftAttack;
        private System.Windows.Forms.ComboBox rightAttack;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
    }
}

