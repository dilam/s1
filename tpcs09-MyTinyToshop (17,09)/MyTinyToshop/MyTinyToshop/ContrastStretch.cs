using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyTinyToshop
{
    public static class ContrastStretch
    {

        public static Dictionary<char, int[]> GetHistogram(Bitmap img)
        {
            Dictionary<char, int[]> hist = new Dictionary<char, int[]>
                                           { { 'R', new int[256] },
                                             { 'G', new int[256] },
                                             { 'B', new int[256] } };

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color color = img.GetPixel(i, j);

                    hist['R'][color.R]++;
                    hist['G'][color.G]++;
                    hist['B'][color.B]++;
                }
            }

            return hist;
        }

        private static int FindLow(int[] hist)
        {
            int i = 0;

            while (i <= 255 && hist[i] == 0)
            {
                i++;
            }

            return (i < 256) ? i : 0;
        }

        private static int FindHigh(int[] hist)
        {
            int i = 255;

            while (i >= 0 && hist[i] == 0)
            {
                i--;
            }

            return (i > -1) ? i : 255;
        }

        public static Dictionary<char, int>
        FindBound(Dictionary<char, int[]> hist, Func<int[], int> f)
        {
            Dictionary<char, int> bound = new Dictionary<char, int>();

            bound.Add('R', f(hist['R']));
            bound.Add('G', f(hist['G']));
            bound.Add('B', f(hist['B']));

            return bound;
        }


        public static int[] ComputeLUT(int low, int high)
        {
            int[] LUT = new int[256];

            for (int i = 0; i < 256; i++)
            {
                LUT[i] = (i < low) ? 0 : (i < high) ? (255 * (i - low) / (high - low)) : 255;
            }

            return LUT;
        }

        public static Dictionary<char, int[]> GetLUT(Bitmap img)
        {
            Dictionary<char, int[]> LUT = new Dictionary<char, int[]>();
            Dictionary<char, int[]> hist = GetHistogram(img);

            int lowR = FindLow(hist['R']);
            int highR = FindHigh(hist['R']);

            int lowG = FindLow(hist['G']);
            int highG = FindHigh(hist['G']);

            int lowB = FindLow(hist['B']);
            int highB = FindHigh(hist['B']);

            LUT.Add('R', ComputeLUT(lowR, highR));
            LUT.Add('G', ComputeLUT(lowG, highG));
            LUT.Add('B', ComputeLUT(lowR, highB));

            return LUT;
        }

        public static Image ConstrastStretch(Bitmap img)
        {
            Dictionary<char, int[]> LUT = GetLUT(img);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color color = img.GetPixel(i, j);
                    img.SetPixel(i, j, Color.FromArgb(LUT['R'][color.R], LUT['G'][color.G], LUT['B'][color.B]));
                }
            }

            return img;
        }

    }
}
