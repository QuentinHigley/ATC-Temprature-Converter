using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempratureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCelc_Click(object sender, EventArgs e)
        {
            try
            {
                double dblInput, dblCelc;
                dblInput = Convert.ToDouble(txtInput.Text);
                dblCelc = .556 * (dblInput - 32);
                lblOutput.Text = "Temprature: " + dblCelc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnFaren_Click(object sender, EventArgs e)
        {
            try
            {
                double dblInput, dblFaren;
                dblInput = Convert.ToDouble(txtInput.Text);
                dblFaren = 1.8 * dblInput + 32;
                lblOutput.Text = "Temprature: " + dblFaren;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
