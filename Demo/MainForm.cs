using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            OutputTB.Text = "Hello World from Button";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OutputTB.Text = "Hello World from Form";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int var1 = Convert.ToInt32(textBox1.Text);
            int var2 = int.Parse(textBox2.Text);

            OutputTB.Text = var1 + var2 + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double var1 = Convert.ToInt32(textBox1.Text);
            double var2 = Convert.ToInt32(textBox2.Text);
            double var3 = var1 / var2;

            var3 = Math.Round(var3, 1);

            OutputTB.Text = var3 + "";
        }
    }
}
