using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Brainfuck
{
    public partial class IDE : Form
    {
        public IDE()
        {
            InitializeComponent();
        }

        private void interpret_Click(object sender, EventArgs e)
        {
            Brainfuck.interpret(textBox1.Text);
        }

        private void generate_Click(object sender, EventArgs e)
        {
            textBox1.Text = Brainfuck.generate_code_from_text(textBox1.Text);
        }

        private void compress_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            string tmp1 = Brainfuck.shorten_code(tmp);
            HuffmanCode h = new HuffmanCode(tmp.Length < tmp1.Length ? tmp : tmp1);
            if (print_code.Checked)
                h.print_code();
            textBox2.Clear();
            textBox2.Text = h.huffman_program_;
        }

        private void shorten_Click(object sender, EventArgs e)
        {
            textBox1.Text = Brainfuck.shorten_code(textBox1.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, textBox1.Text);
            }
        }

        private void import_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(op.FileName);
            }
        }

        private void import_cfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = File.ReadAllText(op.FileName);
            }
        }

        private void decompress_Click(object sender, EventArgs e)
        {
            string tmp = textBox2.Text;
            textBox1.Clear();
            textBox1.Text = HuffmanCode.get_brainfuck_from_huffman(tmp);
        }

        private void save_compression_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, textBox2.Text);
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            string code;
            if (textBox1.Text.Length == 0)
                code = Brainfuck.generate_code_from_text("Coucou les sups c'est vos ACDC qui vous parlent!");
            else
                code = textBox1.Text;
            original_text.Clear();
            original_text.Text = code.Length + "char";

            string code2 = Brainfuck.shorten_code(code);
            shorten_text.Clear();
            shorten_text.Text = code2.Length + "char";

            HuffmanCode h = new HuffmanCode(code.Length < code2.Length ? code : code2);
            compression_text.Clear();
            compression_text.Text = h.huffman_program_.Length + "char";

            bool_text.Clear();
            string brain = HuffmanCode.get_brainfuck_from_huffman(h.huffman_program_);
            bool c = (brain == h.program_);
            bool_text.Text = c ? "True :)" : "False :(";
            if (!c)
            {
                textBox1.Clear();
                textBox1.Text = h.program_;
                textBox2.Clear();
                textBox2.Text = brain;
            }
        }
    }
}
