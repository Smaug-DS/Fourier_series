using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestFourier
{
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.simpleInteg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 res = new Form1();
            res.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.integral);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.trigon);
        }
    }
}
