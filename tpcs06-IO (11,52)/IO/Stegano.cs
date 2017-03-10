using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Stegano
    {
        private static int get_bit(byte b, int index)
        {
            if (index < 7 || index > 0)
            {
                string s = Convert.ToString(b, 2);
                while (s.Length < 8)
                {
                    s = "0" + s;
                }
                Console.WriteLine(s);
                if (s[index] == '0')
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }

            return 0;
        }

        private static void set_next_coords(ref int x, ref int y, System.Drawing.Bitmap image)
        {
            int h = (int) image.HorizontalResolution;
            if (x > h)
            {
                x = 0;
                y = y + 1;
            }
            else
            {
                x = x + 1;
            }
        }

        public static void hide(string path, string text)
        {
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(path);
            // Used to mark the end of the string
            text += '\0';
            // FIXME
            bmp.Save(path + "_out.bmp");
        }

        public static string reveal(string path)
        {
            string result = "";
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(path);
            // FIXME
            return result;
        }
    }
}
