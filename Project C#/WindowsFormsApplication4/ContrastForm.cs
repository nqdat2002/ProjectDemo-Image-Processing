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
    public partial class ContrastForm : Form
    {
        public ContrastForm()
        {
            InitializeComponent();
        }

        private double contrastValue = 0;

        private void ok_button_Click(object sender, EventArgs e)
        {
            contrastValue = String.IsNullOrEmpty(contrast_textBox.Text) ? 0 : Convert.ToDouble(contrast_textBox.Text);
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public double getContrast()
        {
            return contrastValue;
        }
    }
}
