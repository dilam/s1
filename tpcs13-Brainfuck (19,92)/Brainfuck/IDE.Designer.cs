namespace Brainfuck
{
    partial class IDE
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
            this.interpret = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.compress = new System.Windows.Forms.Button();
            this.shorten = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.import_file = new System.Windows.Forms.Button();
            this.import_cfile = new System.Windows.Forms.Button();
            this.decompress = new System.Windows.Forms.Button();
            this.save_compression = new System.Windows.Forms.Button();
            this.print_code = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.bool_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shorten_text = new System.Windows.Forms.TextBox();
            this.compression_text = new System.Windows.Forms.TextBox();
            this.original_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // interpret
            // 
            this.interpret.Location = new System.Drawing.Point(12, 12);
            this.interpret.Name = "interpret";
            this.interpret.Size = new System.Drawing.Size(89, 23);
            this.interpret.TabIndex = 0;
            this.interpret.Text = "Interpret";
            this.interpret.UseVisualStyleBackColor = true;
            this.interpret.Click += new System.EventHandler(this.interpret_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(12, 41);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(89, 23);
            this.generate.TabIndex = 1;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // compress
            // 
            this.compress.Location = new System.Drawing.Point(12, 70);
            this.compress.Name = "compress";
            this.compress.Size = new System.Drawing.Size(89, 23);
            this.compress.TabIndex = 2;
            this.compress.Text = "Compress";
            this.compress.UseVisualStyleBackColor = true;
            this.compress.Click += new System.EventHandler(this.compress_Click);
            // 
            // shorten
            // 
            this.shorten.Location = new System.Drawing.Point(12, 122);
            this.shorten.Name = "shorten";
            this.shorten.Size = new System.Drawing.Size(89, 23);
            this.shorten.TabIndex = 3;
            this.shorten.Text = "Shorten";
            this.shorten.UseVisualStyleBackColor = true;
            this.shorten.Click += new System.EventHandler(this.shorten_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 151);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(89, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // import_file
            // 
            this.import_file.Location = new System.Drawing.Point(12, 180);
            this.import_file.Name = "import_file";
            this.import_file.Size = new System.Drawing.Size(89, 23);
            this.import_file.TabIndex = 5;
            this.import_file.Text = "Import File";
            this.import_file.UseVisualStyleBackColor = true;
            this.import_file.Click += new System.EventHandler(this.import_file_Click);
            // 
            // import_cfile
            // 
            this.import_cfile.Location = new System.Drawing.Point(12, 238);
            this.import_cfile.Name = "import_cfile";
            this.import_cfile.Size = new System.Drawing.Size(89, 48);
            this.import_cfile.TabIndex = 6;
            this.import_cfile.Text = "Import compressed file";
            this.import_cfile.UseVisualStyleBackColor = true;
            this.import_cfile.Click += new System.EventHandler(this.import_cfile_Click);
            // 
            // decompress
            // 
            this.decompress.Location = new System.Drawing.Point(12, 292);
            this.decompress.Name = "decompress";
            this.decompress.Size = new System.Drawing.Size(89, 23);
            this.decompress.TabIndex = 7;
            this.decompress.Text = "Decompress";
            this.decompress.UseVisualStyleBackColor = true;
            this.decompress.Click += new System.EventHandler(this.decompress_Click);
            // 
            // save_compression
            // 
            this.save_compression.Location = new System.Drawing.Point(12, 321);
            this.save_compression.Name = "save_compression";
            this.save_compression.Size = new System.Drawing.Size(88, 49);
            this.save_compression.TabIndex = 8;
            this.save_compression.Text = "Save compression";
            this.save_compression.UseVisualStyleBackColor = true;
            this.save_compression.Click += new System.EventHandler(this.save_compression_Click);
            // 
            // print_code
            // 
            this.print_code.AutoSize = true;
            this.print_code.Location = new System.Drawing.Point(12, 99);
            this.print_code.Name = "print_code";
            this.print_code.Size = new System.Drawing.Size(74, 17);
            this.print_code.TabIndex = 9;
            this.print_code.Text = "Print code";
            this.print_code.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 220);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 238);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(377, 132);
            this.textBox2.TabIndex = 11;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(491, 13);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 12;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // bool_text
            // 
            this.bool_text.Location = new System.Drawing.Point(595, 16);
            this.bool_text.Name = "bool_text";
            this.bool_text.Size = new System.Drawing.Size(100, 20);
            this.bool_text.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "After shorten_code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "After compression";
            // 
            // shorten_text
            // 
            this.shorten_text.Location = new System.Drawing.Point(595, 69);
            this.shorten_text.Name = "shorten_text";
            this.shorten_text.Size = new System.Drawing.Size(100, 20);
            this.shorten_text.TabIndex = 17;
            // 
            // compression_text
            // 
            this.compression_text.Location = new System.Drawing.Point(595, 95);
            this.compression_text.Name = "compression_text";
            this.compression_text.Size = new System.Drawing.Size(100, 20);
            this.compression_text.TabIndex = 18;
            // 
            // original_text
            // 
            this.original_text.Location = new System.Drawing.Point(595, 43);
            this.original_text.Name = "original_text";
            this.original_text.Size = new System.Drawing.Size(100, 20);
            this.original_text.TabIndex = 19;
            // 
            // IDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 382);
            this.Controls.Add(this.original_text);
            this.Controls.Add(this.compression_text);
            this.Controls.Add(this.shorten_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bool_text);
            this.Controls.Add(this.check);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.print_code);
            this.Controls.Add(this.save_compression);
            this.Controls.Add(this.decompress);
            this.Controls.Add(this.import_cfile);
            this.Controls.Add(this.import_file);
            this.Controls.Add(this.save);
            this.Controls.Add(this.shorten);
            this.Controls.Add(this.compress);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.interpret);
            this.Name = "IDE";
            this.Text = "IDE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button interpret;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button compress;
        private System.Windows.Forms.Button shorten;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button import_file;
        private System.Windows.Forms.Button import_cfile;
        private System.Windows.Forms.Button decompress;
        private System.Windows.Forms.Button save_compression;
        private System.Windows.Forms.CheckBox print_code;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox bool_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shorten_text;
        private System.Windows.Forms.TextBox compression_text;
        private System.Windows.Forms.TextBox original_text;
    }
}