using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odleglosci
{
    public partial class Form1 : Form
    {

        byte wyb;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMilaM_CheckedChanged(object sender, EventArgs e)
        {
            wyb = 1;
        }

        private void rbMilaL_CheckedChanged(object sender, EventArgs e)
        {
            wyb = 2;
        }

        private void rbJard_CheckedChanged(object sender, EventArgs e)
        {
            wyb = 3;
        }

        private void rbStopa_CheckedChanged(object sender, EventArgs e)
        {
            wyb= 4;
        }

        private void rbCal_CheckedChanged(object sender, EventArgs e)
        {
            wyb= 5;
        }

        private void btnPolicz_Click(object sender, EventArgs e)
        {
            try
            {
                double metry = double.Parse(tbOdleg.Text);
                double wynik = 0;
                switch (wyb)
                {
                    case 1:
                        wynik = metry / 1852;
                        break;
                    case 2:
                        wynik = metry / 1609.344;
                        break;
                    case 3:
                        wynik = metry / 0.9144;
                        break;
                    case 4:
                        wynik = metry / 0.30477;
                        break;
                    case 5:
                        wynik = metry / 0.0254;
                        break;
                }
                tbWynik.Text = wynik.ToString();
            }
            catch(Exception) {
                MessageBox.Show("Podaj liczbę!");
            }
        }
    }
}
