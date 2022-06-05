using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" )
            {
                if(textBox2.Text == "12345")
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                    Hide();
                }
                
            }
            else
            {
                MessageBox.Show("Test");
            }
        }
    }
}
