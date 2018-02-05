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
    public partial class Form1 : Form
    {
        Form2 frm2 = new Form2();
       


        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                frm2.textBox1.Text = "1";
               
            }
            if (radioButton2.Checked == true)
            {
                frm2.textBox1.Text = "0";
            }
            if (radioButton3.Checked == true)
            {
                frm2.textBox1.Text = "2";
            }
            frm2.Show();

            this.Hide();

        }
    }
}
