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
    public partial class brightnessForm : Form
    {
        public brightnessForm()
        {
            InitializeComponent();
        }

        private int brightnessValue = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            brightnessValue = String.IsNullOrEmpty(brightness_textBox.Text) ? 0 : Convert.ToInt32(brightness_textBox.Text);
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int getBrightness()
        {
            return brightnessValue;
        }

        private void brightnessForm_Load(object sender, EventArgs e)
        {

        }
    }
}
