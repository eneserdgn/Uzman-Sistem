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
    public partial class Form2 : Form
    {
        Form3 frm3 = new Form3();
      

        public Form2()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                frm3.textBox1.Text = textBox1.Text + "1";
            }
            if (radioButton2.Checked == true)
            {
                frm3.textBox1.Text = textBox1.Text + "0";
            }
            if (radioButton3.Checked == true)
            {
                frm3.textBox1.Text = textBox1.Text + "2";
            }

            
            frm3.Show();
            this.Hide();

        }

        
    }
}
