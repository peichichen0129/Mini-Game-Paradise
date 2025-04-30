using finalproject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalhw1103868
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "peggy29" && textBox2.Text == "1234") 
            {

                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                f1 = null;
                this.Show();
            }
             else
            {
               MessageBox.Show("密碼錯誤");
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
