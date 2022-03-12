using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class ConvertPicture
    {
        // Chuyển thành ảnh xám
        public static bool convertToGray(Bitmap picture)
        {
            for (int i = 0; i < picture.Width; i++)
                for(int j = 0; j<picture.Height; j++)
                {
                    Color color = picture.GetPixel(i, j);
                    int red = color.R;
                    int green = color.G;
                    int blue = color.B;
                    int gray = (byte)(.287 * red + .599 * green + .114 * blue);
                    picture.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            return true;
        }

        // Chuyển thành âm bản
        public static bool convertToNegative(Bitmap picture)
        {
            for (int i = 0; i < picture.Width; i++)
                for (int j = 0; j < picture.Height; j++)
                {
                    Color color = picture.GetPixel(i, j);
                    int red = 255 - color.R;
                    int green = 255 - color.G;
                    int blue = 255 - color.B;
                    picture.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            return true;
        }
    }
}
