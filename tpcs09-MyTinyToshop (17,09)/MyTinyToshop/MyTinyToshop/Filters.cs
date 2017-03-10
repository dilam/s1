using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyTinyToshop
{
    public static class Filters
    {
        public static Color Tint { get; set; }
        public static int Coef { get; set; }

        public static Bitmap MapPixels(Bitmap img, Func<Color, Color> filter,
                                       int xB, int yB, int xE, int yE)
        {
            for (int x = xB; x < xE; x++)
            {
                for (int y = yB; y < yE; y++)
                {
                    img.SetPixel(x, y, filter(img.GetPixel(x, y)));
                }
            }

            return img;
        }

        public static Bitmap MapPixels(Bitmap img, Func<Color, Color> filter)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    img.SetPixel(x, y, filter(img.GetPixel(x, y)));
                }
            }

            return img;
        }

        public static Color Greyscale(Color color)
        {
            int gris = (color.R + color.G + color.B) / 3;

            color = Color.FromArgb(gris, gris, gris);

            return color; 
        }

        public static Color Negative(Color color)
        {
            color = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);

            return color; 
        }

        public static Color Binarize(Color color)
        {
            int bin = ((color.R + color.G + color.B) / 3 < 128) ? 0 : 255;

            color = Color.FromArgb(bin, bin, bin);

            return color; 
        }

        public static Color Tinter(Color color)
        {
            int r = (int)((Tint.R - color.R) * ((float)Coef / 100) + color.R);
            int g = (int)((Tint.G - color.G) * ((float)Coef / 100) + color.G);
            int b = (int)((Tint.B - color.B) * ((float)Coef / 100) + color.B);

            color = Color.FromArgb(r, g, b);

            return color; 
        }

        public static Image Stripes(Bitmap img, Color[] colors)
        {
            int nb = colors.Count();
            int stripes = img.Width / nb;

            for (int i = 0; i < nb; i++)
            {
                Tint = colors[i];
                MapPixels(img, Tinter, i * stripes, 0, (i + 1) * stripes, img.Height);
            }

            return img;
        }
    }
}
