using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck
{
    public class HuffmanCode
    {    
        public string program_;
        public string huffman_program_;
        public Dictionary<char, string> encodings_ = new Dictionary<char, string>();
        public Tree huffman_tree_;

        public HuffmanCode(string program)
        {
            this.program_ = program;
            generate_huffman_code(program);
        }

        public void print_code()
        {
            foreach (KeyValuePair<char, string> kvp in encodings_)
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
        }

        public string encode_huffman_tree(Tree H, string result = "")
        {
            if (H == null)
                return result;
            else if (H.Symbole() != '&')
                return result + 1 + Convert.ToString((int)H.Symbole(), 2);
            else
            {
                result = encode_huffman_tree(H.Left(), result + '0');
                result = encode_huffman_tree(H.Right(), result);
                return result;
            }
        }

        public string get_huffman_from_brainfuck()
        {
            huffman_program_ = encode_huffman_tree(huffman_tree_);

            string encoded = "";
            int lon = program_.Length;

            for (int i = 0; i < lon; i++)
                encoded += encodings_[program_[i]];

            string result = "";
            int l = encoded.Length;
            int p = 0;

            string s = "";

            for (int i = 0; i < l / 8; i++)
            {
                s = "";
                for (int j = p; j < p + 8; j++)
                    s += encoded[j];
                result += Convert.ToChar(Convert.ToInt32(s, 2));
                p += 8;
            }

            s = "";

            for (int i = p; i < p + l % 8; i++)
                s += encoded[i];

            result += Convert.ToChar(Convert.ToInt32(s, 2));

            return result;
        }

        public static string get_brainfuck_from_huffman(string huffman_code)
        {
            string bin = "";
            int lon = huffman_code.Length;

            for (int i = 0; i < lon; i++)
                bin += Convert.ToString((int)huffman_code[i], 2);

            int l = bin.Length;
            int j = 0;
            string result = "";
            string s = "";

            while (j < l)
            {
                s += bin[j];
                if(encodings.ContainsKey(Convert.ToChar(Convert.ToInt32(s, 2))))
                {
                    result += Convert.ToChar(Convert.ToInt32(s, 2));
                    s = "";
                }
                j++;
            }

            return result;
        }

        private void generate_huffman_code_rec(Tree t, string path, Dictionary<char, string> encodings)
        {
            if (t.Left() == null || t.Right() == null)
                encodings.Add(t.Symbole(), path);
            else
            {
                generate_huffman_code_rec(t.Left(), path + '0', encodings);
                generate_huffman_code_rec(t.Right(), path + '1', encodings);
            }
        }

        private void generate_huffman_code(string program)
        {
            List<Tuple<int, char>> occurences = new List<Tuple<int, char>>();
            
            int lon = program.Length;

            for (int i = 0; i < lon; i++)
            {
                Tuple<int, char> test = new Tuple<int, char>(0, ' ');
                int j = 0;

                while (j < occurences.Count && program[i] != test.Item2)
                {
                    test = occurences[j];
                    j++;
                }

                if (program[i] == test.Item2)
                    occurences[j - 1] = new Tuple<int, char>(test.Item1 + 1, test.Item2);
                else
                    occurences.Add(new Tuple<int, char>(1, program[i]));
            }

            occurences = occurences.OrderBy(i => i.Item1).ToList();

            Stack<Tree> priority = new Stack<Tree>();

            for (int i = occurences.Count; i >= 0; i--)
                priority.Push(new Tree(null, null, occurences[i].Item1, occurences[i].Item2));

            while (priority.Count > 1)
            {
                Tree node1 = priority.Pop();
                Tree node2 = priority.Pop();
                priority.Push(new Tree(node1, node2, node1.GetFrequency() + node2.GetFrequency(), '&'));
            }

            huffman_tree_ = priority.Pop();

            generate_huffman_code_rec(huffman_tree_, "", encodings_);
        }
    }
}
