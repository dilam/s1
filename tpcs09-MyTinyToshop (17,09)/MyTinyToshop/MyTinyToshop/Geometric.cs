using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyTinyToshop
{
    public static class Geometric
    {
        public static Image HorizontalMirror(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;

            Bitmap img2 = new Bitmap(width, height, img.PixelFormat);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    img2.SetPixel(x, y, img.GetPixel(width - x - 1, y));
                }
            }

            return img2;
        }

        public static Image VerticalMirror(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;

            Bitmap img2 = new Bitmap(width, height, img.PixelFormat);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    img2.SetPixel(x, y, img.GetPixel(x, height - y - 1));
                }
            }

            return img2;
        }

        public static Image LeftRotation(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;

            Bitmap img2 = new Bitmap(height, width, img.PixelFormat);

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    img2.SetPixel(x, y, img.GetPixel(y, x));
                }
            }

            return img2;
        }

        public static Image RightRotation(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;

            Bitmap img2 = new Bitmap(height, width, img.PixelFormat);

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    img2.SetPixel(x, y, img.GetPixel(width - y - 1, height - x - 1));
                }
            }

            return img2;
        }
    }
}
