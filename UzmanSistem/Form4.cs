using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UzmanSistem
{
    public partial class Form4 : Form
    {
        OleDbConnection con;



        public Form4()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a;
            int b;
            string c;
            
            int toplam;
            int encoktekrar;
            a = textBox1.Text;
            
            string secim= textBox1.Text;

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kayit.accdb");
            con.Open();
            string kayit = "insert into ogrenci([secim]) values('"+secim+ "')";
            OleDbCommand komut = new OleDbCommand(kayit, con); 
            komut.ExecuteNonQuery();
            con.Close();

            con.Open();
            OleDbCommand Cmd = new OleDbCommand("SELECT COUNT(*) FROM ogrenci", con);
            toplam = (int)Cmd.ExecuteScalar();
           
            con.Close();
            con.Open();
            OleDbCommand rar = new OleDbCommand("SELECT count(secim) from ogrenci group by secim  order by count(*) desc", con);
            encoktekrar = (int)rar.ExecuteScalar();
            label4.Text = ("%"+(encoktekrar*100/toplam).ToString());
           
            con.Close();
            con.Open();
            OleDbCommand raraa = new OleDbCommand("SELECT secim from ogrenci group by secim  order by count(*) desc", con);
            b = (int)raraa.ExecuteScalar();   //en cok tekrar eden ismi
            c = b.ToString();
            con.Close();


            //"SELECT ogrenciID, count(secim) from ogrenci group by secim  order by count(*) desc"


            if (a == "000")
            {
                
                textBox2.Text = "Polis";
            }

            else if (a == "001")
            {
                textBox2.Text = "Çiftçi";
            }
            else if (a == "002")
            {
                textBox2.Text = "Çöpçü";
            }
            else if (a == "010")
            {
                textBox2.Text = "Öğretmen";
            }
            else if (a == "011")
            {
                textBox2.Text = "Öğretmen";
            }
            else if (a == "012")
            {
                textBox2.Text = "Çiftçi";
            }
            else if (a == "020")
            {
                textBox2.Text = "Memur";
            }
            else if (a == "021")
            {
                textBox2.Text = "Çiftçi";
            }
            else if (a == "022")
            {
                textBox2.Text = "Çiftçi";
            }
            else if (a == "100")
            {
                textBox2.Text = "Polis";
            }

            else if (a == "101")
            {
                textBox2.Text = "Müdür";
            }
            else if (a == "102")
            {
                textBox2.Text = "Mühendis";
            }
            else if (a == "110")
            {
                textBox2.Text = "Mühendis";
            }
            else if (a == "111")
            {
                textBox2.Text = "CEO";
            }
            else if (a == "112")
            {
                textBox2.Text = "Mühendis";
            }
            else if (a == "120")
            {
                textBox2.Text = "Doktor";
            }
            else if (a == "121")
            {
                textBox2.Text = "Doktor";
            }
            else if (a == "122")
            {
                textBox2.Text = "Doktor";
            }
            else if (a == "200")
            {
                textBox2.Text = "Polis";
            }

            else if (a == "201")
            {
                textBox2.Text = "Politikacı";
            }
            else if (a == "202")
            {
                textBox2.Text = "Avukat";
            }
            else if (a == "210")
            {
                textBox2.Text = "Savcı";
            }
            else if (a == "211")
            {
                textBox2.Text = "Politikacı";
            }
            else if (a == "212")
            {
                textBox2.Text = "Avukat";
            }
            else if (a == "220")
            {
                textBox2.Text = "Hakim";
            }
            else if (a == "221")
            {
                textBox2.Text = "Politikacı";
            }
            else //222
            {
                textBox2.Text = "Avukat";
            }

            if (c == "000")
            {

                label5.Text = "Polis";
            }

            else if (c == "001")
            {
                label5.Text = "Çiftçi";
            }
            else if (c == "002")
            {
                label5.Text = "Çöpçü";
            }
            else if (c == "010")
            {
                label5.Text = "Öğretmen";
            }
            else if (c == "011")
            {
                label5.Text = "Öğretmen";
            }
            else if (c == "012")
            {
                label5.Text = "Çiftçi";
            }
            else if (c == "020")
            {
                label5.Text = "Memur";
            }
            else if (c == "021")
            {
                label5.Text = "Çiftçi";
            }
            else if (c == "022")
            {
                label5.Text = "Çiftçi";
            }
            else if (c == "100")
            {
                label5.Text = "Polis";
            }

            else if (c == "101")
            {
                label5.Text = "Müdür";
            }
            else if (c == "102")
            {
                label5.Text = "Mühendis";
            }
            else if (c == "110")
            {
                label5.Text = "Mühendis";
            }
            else if (c == "111")
            {
                label5.Text = "CEO";
            }
            else if (c == "112")
            {
                label5.Text = "Mühendis";
            }
            else if (c == "120")
            {
                label5.Text = "Doktor";
            }
            else if (c == "121")
            {
                label5.Text = "Doktor";
            }
            else if (c == "122")
            {
                label5.Text = "Doktor";
            }
            else if (c == "200")
            {
                label5.Text = "Polis";
            }

            else if (c == "201")
            {
                label5.Text = "Politikacı";
            }
            else if (c == "202")
            {
                label5.Text = "Avukat";
            }
            else if (c == "210")
            {
                label5.Text = "Savcı";
            }
            else if (c == "211")
            {
                label5.Text = "Politikacı";
            }
            else if (c == "212")
            {
                label5.Text = "Avukat";
            }
            else if (c == "220")
            {
                label5.Text = "Hakim";
            }
            else if (c == "221")
            {
                textBox2.Text = "Politikacı";
            }
            else //222
            {
                label5.Text = "Avukat";
            }
        }
    }
}
