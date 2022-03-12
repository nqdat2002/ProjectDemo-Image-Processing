using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Filter
    {

        public static bool toEDGE(Bitmap picture)
        {
            int[] matrix = new int[9];
            int[,] pixelPicture = new int[picture.Width - 2, picture.Height - 2];
            int[,] pixelPicture1 = new int[picture.Width-2,picture.Height-2];
            int[,] pixelPicture2 = new int[picture.Width - 2, picture.Height - 2];
            int pixel;
            int count = 0;
            for(int i =0; i<picture.Width-2; i++)
                for(int j=0; j<picture.Height-2; j++)
                {
                    count = 0;
                    for (int n = i; n <= i + 2; n++)
                        for (int m = j; m <= j + 2; m++)
                        {
                            Color color = picture.GetPixel(n, m);
                            matrix[count] = color.R;
                            count++;
                        }
                    pixel = matrix[0] * -1 + matrix[1] * -2 + matrix[3] * -1 + matrix[6] * 1 + matrix[7] * 2 + matrix[8] * 1;
                    pixelPicture1[i, j] = pixel;
                    
                }
            for (int i = 0; i < picture.Width - 2; i++)
                for (int j = 0; j < picture.Height - 2; j++)
                {
                    count = 0;
                    for (int n = i; n <= i + 2; n++)
                        for (int m = j; m <= j + 2; m++)
                        {
                            Color color = picture.GetPixel(n, m);
                            matrix[count] = color.R;
                            count++;
                        }
                    pixel = matrix[0] * -1 + matrix[2] * 1 + matrix[3] * -2 + matrix[5] * 2 + matrix[6] * -1 + matrix[8] * 1;
                    pixelPicture2[i, j] = pixel;

                }
            for (int i = 0; i < picture.Width - 2; i++)
                for (int j = 0; j < picture.Height - 2; j++)
                {
                    pixelPicture[i, j] = Math.Abs(pixelPicture1[i, j]) + Math.Abs(pixelPicture2[i, j]);
                }
            for (int i = 0; i < picture.Width - 2; i++)
                for (int j = 0; j < picture.Height - 2; j++)
                {
                    Color color = picture.GetPixel(i, j);
                    if (pixelPicture[i, j] > 255)
                        picture.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    else
                        picture.SetPixel(i, j, Color.FromArgb(pixelPicture[i, j], pixelPicture[i, j], pixelPicture[i, j]));
                }
            return true;
        }
    }
}
