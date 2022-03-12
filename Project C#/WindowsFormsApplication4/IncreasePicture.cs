using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class IncreasePicture
    {
        public static bool increaseBrightness(Bitmap picture, int value)
        {
            // Vòng lặp
            for (int i = 0; i < picture.Width; i++)
                for (int j = 0; j < picture.Height; j++)
                {
                    // Lấy giá trị
                    Color color = picture.GetPixel(i, j);
                    // Tính
                    int red = color.R + value < 255 ? color.R + value : 255;
                    int green = color.G + value < 255 ? color.G + value : 255;
                    int blue = color.B + value < 255 ? color.B + value : 255;
                    // Thiết lập lại
                    picture.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            return true;
        }

        public static bool increaseContrast(Bitmap picture, double value)
        {
            // Khai báo các biến
            int R = 0, G = 0, B = 0;
            double T;
            Color color;

            if (value <= -100 && value >= 100)
                return false;

            // Tính ban đầu
            value = (100.0 + value) / 100.0;
            value *= value;

            // Vòng lặp đọc điểm ảnh
            for (int i = 0; i < picture.Height; i++)
            {
                for (int j = 0; j < picture.Width; j++)
                {
                    color = picture.GetPixel(i, j);

                    T = color.R / 255.0;
                    T -= 0.5;
                    T *= value;
                    T += 0.5;
                    T *= 255;
                    if (T > 255)
                        R = 255;
                    else if (T < 0)
                        R = 0;

                    T = color.G / 255.0;
                    T -= 0.5;
                    T *= value;
                    T += 0.5;
                    T *= 255;
                    if (T > 255)
                        G = 255;
                    else if (T < 0)
                        G = 0;

                    T = color.B / 255.0;
                    T -= 0.5;
                    T *= value;
                    T += 0.5;
                    T *= 255;
                    if (T > 255)
                        B = 255;
                    else if (T < 0)
                        B = 0;

                    picture.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return true;
        }
    }
}
