namespace IO
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.hide_button = new System.Windows.Forms.Button();
            this.reveal_button = new System.Windows.Forms.Button();
            this.split_button = new System.Windows.Forms.Button();
            this.merge_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.strings_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // hide_button
            // 
            this.hide_button.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.hide_button.Location = new System.Drawing.Point(63, 330);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(250, 55);
            this.hide_button.TabIndex = 1;
            this.hide_button.Text = "hide";
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // reveal_button
            // 
            this.reveal_button.Location = new System.Drawing.Point(325, 330);
            this.reveal_button.Name = "reveal_button";
            this.reveal_button.Size = new System.Drawing.Size(251, 55);
            this.reveal_button.TabIndex = 2;
            this.reveal_button.Text = "reveal";
            this.reveal_button.UseVisualStyleBackColor = true;
            this.reveal_button.Click += new System.EventHandler(this.reveal_button_Click);
            // 
            // split_button
            // 
            this.split_button.Location = new System.Drawing.Point(63, 214);
            this.split_button.Name = "split_button";
            this.split_button.Size = new System.Drawing.Size(250, 57);
            this.split_button.TabIndex = 3;
            this.split_button.Text = "split";
            this.split_button.UseVisualStyleBackColor = true;
            this.split_button.Click += new System.EventHandler(this.split_button_Click);
            // 
            // merge_button
            // 
            this.merge_button.Location = new System.Drawing.Point(325, 214);
            this.merge_button.Name = "merge_button";
            this.merge_button.Size = new System.Drawing.Size(251, 57);
            this.merge_button.TabIndex = 4;
            this.merge_button.Text = "merge";
            this.merge_button.UseVisualStyleBackColor = true;
            this.merge_button.Click += new System.EventHandler(this.merge_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(63, 412);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 238);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // strings_button
            // 
            this.strings_button.Location = new System.Drawing.Point(63, 74);
            this.strings_button.Name = "strings_button";
            this.strings_button.Size = new System.Drawing.Size(513, 59);
            this.strings_button.TabIndex = 7;
            this.strings_button.Text = "strings";
            this.strings_button.UseVisualStyleBackColor = true;
            this.strings_button.Click += new System.EventHandler(this.strings_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 662);
            this.Controls.Add(this.strings_button);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.merge_button);
            this.Controls.Add(this.split_button);
            this.Controls.Add(this.reveal_button);
            this.Controls.Add(this.hide_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button reveal_button;
        private System.Windows.Forms.Button split_button;
        private System.Windows.Forms.Button merge_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button strings_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;


    }
}

