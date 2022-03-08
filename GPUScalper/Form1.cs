using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPUScalper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNRun_Click(object sender, EventArgs e)
        {
            double RRP;
            double FinalPrice;
            double rate = 1.5;

            RRP = double.Parse(txtNGPU.Text);

            FinalPrice = RRP * rate;

            lblOutput.Text = FinalPrice.ToString();

            



        }
    }
}
