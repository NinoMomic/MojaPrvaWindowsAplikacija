using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaPrvaWindowsAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzracun_Click(object sender, EventArgs e)
        {
            try
            { 
            int BrojA, BrojB, Zbroj=0;
            BrojA = Convert.ToInt32(txtUnosBrojaA.Text);
            BrojB = Convert.ToInt32(txtUnosBrojaB.Text);
            Zbroj = BrojA + BrojB;
            txtIznos.Text = Convert.ToString(Zbroj);
            }
            catch(Exception greska)
            {
                Console.WriteLine("Neispravan unos, pokusajte ponovo!");
                Console.WriteLine("Opis greske: "+greska.Message);
            }
        }
    }
}
