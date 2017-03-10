using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Strings
    {
        static bool is_printable(char c)
        {
            return (c > 32 && c < 127);
        }
        public static string strings(string path)
        {
            string result = "";
            string sc = "";
            int cpt = 0;
            System.IO.FileStream fs
                = new System.IO.FileStream(path,
                System.IO.FileMode.Open,
                System.IO.FileAccess.Read);
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs, Encoding.ASCII);
            while (br.PeekChar() != -1)
            {
                char c = br.ReadChar();
                if (is_printable(c))
                {
                    cpt = cpt + 1;
                    sc = sc + c;
                }
                else
                {
                    if (cpt > 3)
                    {
                        result = result + sc + "\n";
                    }
                    cpt = 0;
                    sc = "";
                }
            }
            fs.Close();
            return result;
        }
    }
}
