using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzmanSistem
{
    public partial class Form3 : Form
    {

        Form4 frm4 = new Form4();
       

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                frm4.textBox1.Text = textBox1.Text + "1";
            }
            if (radioButton2.Checked == true)
            {
                frm4.textBox1.Text = textBox1.Text + "0";
            }
            if (radioButton3.Checked == true)
            {
                frm4.textBox1.Text = textBox1.Text + "2";
            }
            frm4.Show();
            this.Hide();
        }

      
    }
}
