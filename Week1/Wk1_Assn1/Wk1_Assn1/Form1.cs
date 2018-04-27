using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk1_Assn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MoveApplication(object sender, EventArgs e)
        {
            int x = 0;
            string xs = textBox1.Text;
            Int32.TryParse(xs, out x);

            int y = 0;
            string ys = textBox2.Text;
            Int32.TryParse(ys, out y);

            this.Location = new Point(x, y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}