using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyTinyToshop
{
    public static class Convolution
    {
        public static float[,] AverageMask = { { 1/9f, 1/9f, 1/9f },
                                               { 1/9f, 1/9f, 1/9f },
                                               { 1/9f, 1/9f, 1/9f } };

        public static float[,] GaussMask = { { 1/16f, 2/16f, 1/16f },
                                             { 2/16f, 4/16f, 2/16f },
                                             { 1/16f, 2/16f, 1/16f } };

        public static float[,] SharpenMask = { {  0f, -1f, 0f  },
                                               { -1f,  5f, -1f },
                                               {  0f, -1f, 0f  } };

        public static float[,] EdgeEnhanceMask = { {  0f, 0f, 0f },
                                                   { -1f, 1f, 0f },
                                                   {  0f, 0f, 0f } };

        public static float[,] EdgeDetectMask = { { 0f,  1f, 0f },
                                                  { 1f, -4f, 1f },
                                                  { 0f,  1f, 0f } };

        public static float[,] EmbossMask = { { -2f, -1f, 0f },
                                              { -1f,  1f, 1f },
                                              {  0f,  1f, 2f } };


        // Talk about it in Lecture part, Convolution section.
        private static int Clamp(float component)
        {
            if (component < 0)
                component = 0;

            if (component > 255)
                component = 255;

            return (int)component;
        }

        private static bool IsValid(int x, int y, Size size)
        {
            return x >= 0 && x < size.Width && y >= 0 && y < size.Height;
        }

        public static Image Convolute(Bitmap img, float[,] mask)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    float r = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            r += img.GetPixel(((IsValid(x - 1 + i, y, img.Size)) ? x - 1 + i : 0), (((IsValid(x, y - 1 + j, img.Size)) ? y - 1 + j : 0))).R * mask[i, j];
                        }
                    }

                    float g = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            g += img.GetPixel(((IsValid(x - 1 + i, y, img.Size)) ? x - 1 + i : 0), (((IsValid(x, y - 1 + j, img.Size)) ? y - 1 + j : 0))).G * mask[i, j];
                        }
                    }

                    float b = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            b += img.GetPixel(((IsValid(x - 1 + i, y, img.Size)) ? x - 1 + i : 0), (((IsValid(x, y - 1 + j, img.Size)) ? y - 1 + j : 0))).B * mask[i, j];
                        }
                    }

                    img.SetPixel(x, y, Color.FromArgb(Clamp(r), Clamp(g), Clamp(b)));
                }
            }

            return img;
        }
    }
}
