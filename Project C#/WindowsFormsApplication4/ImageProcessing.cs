using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private bool choose = false;

        private void FormMain_Load(object sender, EventArgs e)
        {
            savePicture.Enabled = false;
            showHistogram.Enabled = false;
            equalHistogram.Enabled = false;
            convertToGray.Enabled = false;
            convertToNegative.Enabled = false;
            changeBrightness.Enabled = false;
            contrastToolStripMenuItem.Enabled = false;
            toEDGE.Enabled = false;
        }

        private void openImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.PictureSource.Image = new Bitmap(ofile.FileName);
                savePicture.Enabled = true;
                showHistogram.Enabled = true;
                equalHistogram.Enabled = true;
                convertToGray.Enabled = true;
                convertToNegative.Enabled = true;
                changeBrightness.Enabled = true;
                contrastToolStripMenuItem.Enabled = true;
                toEDGE.Enabled = true;
            }
        }

        // Sự kiện khi click vào nút Save
        private void saveImages_Click(object sender, EventArgs e)
        {
            // Khởi tạo biến save 
            SaveFileDialog save = new SaveFileDialog();
            // Bộ lọc đuôi lưu lại
            save.Filter = "JPEG files(*.jpeg)|*.jpeg";
            // Xác nhận lưu
            if(DialogResult.OK == save.ShowDialog())
            {
                this.PictureResult.Image.Save(save.FileName);
            }
        }

        private void exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertToGray_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(this.PictureSource.Image);
            ConvertPicture.convertToGray(pic);
            this.PictureResult.Image = pic;
        }

        private void convertToNegative_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(this.PictureSource.Image);
            ConvertPicture.convertToNegative(pic);
            this.PictureResult.Image = pic;
        }

        private void showHistogram_Click(object sender, EventArgs e)
        {
            
            Bitmap pic = new Bitmap(this.PictureSource.Image);
            ConvertPicture.convertToNegative(pic);
            Bitmap his = new Bitmap(256, 60);
            Histogram.showHistogram(pic, his);
            this.PictureHistogram.Image = his;
        }

        private void equalHistogram_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(this.PictureSource.Image);
            ConvertPicture.convertToGray(pic);
            Bitmap his = new Bitmap(256, 60);
            Histogram.equalHistogram(pic, his);
            Histogram.showHistogram(pic, his);
            this.PictureResult.Image = pic;
            this.PictureHistogram.Image = his;
        }

        private void changeBrightness_Click(object sender, EventArgs e)
        {
            brightnessForm bnForm = new brightnessForm();
            bnForm.ShowDialog();
            Bitmap pic = new Bitmap(this.PictureSource.Image);
            IncreasePicture.increaseBrightness(pic, bnForm.getBrightness());
            this.PictureResult.Image = pic;
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrastForm ctForm = new ContrastForm();
            ctForm.ShowDialog();
            Bitmap pic = new Bitmap(this.PictureSource.Image);
            IncreasePicture.increaseContrast(pic, ctForm.getContrast());
            this.PictureResult.Image = pic;
        }

        private void about_Click(object sender, EventArgs e)
        {
            About abForm = new About();
            abForm.ShowDialog();
        }

        private void toEDGE_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(this.PictureSource.Image);
            ConvertPicture.convertToGray(pic);
            Filter.toEDGE(pic);
            this.PictureResult.Image = pic;
        }
    }
}
