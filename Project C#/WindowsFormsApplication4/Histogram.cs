using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Histogram
    {
        public static bool showHistogram(Bitmap picture, Bitmap histogram)
        {
            // Biến lưu tất cả giá trị điểm ảnh ban đầu
            int[] pixelValue = new int[picture.Width * picture.Height];
            // Biến đếm
            int count = 0;
            // Vòng lặp lấy ra giá trị của tất cả điểm ảnh ban đầu
            for(int i = 0; i<picture.Width; i++)
                for(int j = 0; j<picture.Height; j++)
                {
                    Color color = picture.GetPixel(i, j);
                    pixelValue[count] = color.R;
                    count++;
                }

            // Biến lưu số lượng các mức xám từ 0-255
            int[] grayValue = new int[256];
            // Reset biến đếm
            count = 0;
            // Vòng lặp đếm số lượng các mức xám
            for (int i = 0; i <= 255; i++)
            {
                for(int j=0; j<picture.Height*picture.Width; j++)
                    if (i == pixelValue[j])
                        count++;
                grayValue[i] = count;
                count = 0;
            }

            // Tìm ra điểm sáng max và chia tỉ lệ để hiển thị Histogram
            int max = grayValue[0];
            for (int i = 1; i <= 255; i++)
                if (grayValue[i] > max)
                    max = grayValue[i];
            // Chia tỉ lệ
            float ratio = histogram.Height / (float)max;
            // Điều chỉnh lại tỉ lệ hiển thị
            for(int i = 0; i<=255; i++)
                grayValue[i] = Convert.ToInt32(grayValue[i] * ratio);

            // Hiển thị Histogram
            // Quét màu đen
            for(int i=0; i<histogram.Width; i++)
                for(int j=0; j<histogram.Height; j++)
                    histogram.SetPixel(i, j, Color.FromArgb(240, 240, 240));
            // Quét điểm ảnh để hiển thị
            for (int i = 0; i < histogram.Width; i++)
                for (int j = 0; j < histogram.Height; j++)
                {
                    if (j >= (histogram.Height - grayValue[i]) && j < histogram.Height)
                        histogram.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                }

            return true;
        }

        public static bool equalHistogram(Bitmap picture, Bitmap histogram)
        {
            // Biến lưu tất cả giá trị điểm ảnh ban đầu
            int[] pixelValue = new int[picture.Width * picture.Height];
            // Biến đếm
            int count = 0;
            // Vòng lặp lấy ra giá trị của tất cả điểm ảnh ban đầu
            for (int i = 0; i < picture.Width; i++)
                for (int j = 0; j < picture.Height; j++)
                {
                    Color color = picture.GetPixel(i, j);
                    pixelValue[count] = color.R;
                    count++;
                }
            
            // Biến lưu số lượng các mức xám từ 0-255
            int[] grayValue = new int[256];
            // Reset biến đếm
            count = 0;
            // Vòng lặp đếm số lượng các mức xám
            for (int i = 0; i <= 255; i++)
            {
                for (int j = 0; j < picture.Height * picture.Width; j++)
                    if (i == pixelValue[j])
                        count++;
                grayValue[i] = count;
                count = 0;
            }

            // Tìm ra độ sáng thấp nhất tổng giá trị sáng
            int min = grayValue[0];
            int allValue = 0;
            for (int i = 0; i <= 255; i++)
            {
                allValue += grayValue[i];
                if (grayValue[i] < min)
                    min = grayValue[i];
            }


            // Chuyển hết mức xám về giá trị mới
            // Biến cộng dồn
            int increment = 0;
            for(int i=0; i<=255; i++)
            {
                //System.Console.WriteLine(allValue);
                increment += grayValue[i];
                double num = (double)(increment - min) / (allValue-1);
                //System.Console.WriteLine(num);
                grayValue[i] = (int)Math.Round(num*255);
                //System.Console.WriteLine(grayValue[i]);
            }

            // Đặt lại ảnh xám
            for (int i = 0; i < picture.Width; i++)
                for (int j = 0; j < picture.Height; j++)
                {
                    Color color = picture.GetPixel(i, j);
                    int value = color.R;
                    picture.SetPixel(i, j, Color.FromArgb(grayValue[value], grayValue[value], grayValue[value]));
                }

        return true;
        }
    }
}
