using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Buffers;
using System.ComponentModel;
using System.Data;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string filehinh = @"C:\Users\admin\source\repos\vet-bay-mau-3.jpg";
            Bitmap hinhgoc = new Bitmap(filehinh);

            pictureBox1.Image = hinhgoc;

            Bitmap red = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap green = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap blue = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            for(int i = 0; i < hinhgoc.Width; i++){
                for(int j = 0; j <hinhgoc.Height; j++){
                    Color c = hinhgoc.GetPixel(i, j);

                    byte R = c.R;
                    byte G = c.G;
                    byte B = c.B;
                    byte A = c.A;

                    red.SetPixel(i, j, Color.FromArgb(A, R, 0, 0));
                    green.SetPixel(i, j, Color.FromArgb(A, 0, G, 0));
                    blue.SetPixel(i, j, Color.FromArgb(A, 0, 0, B));
                }
            }
            pictureBox2.Image = red;
            pictureBox3.Image = green;
            pictureBox4.Image = blue; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}