using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı;

            sayı = Convert.ToDouble(textBox1.Text);
            sayı = sayı * sayı;
            lblsonuc.Text = sayı.ToString();

        }
    }
}
