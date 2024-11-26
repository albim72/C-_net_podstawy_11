using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okno_dni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb1.Items.Add("Niedziela");
            lb1.Items.Add("Poniedziałek");
            lb1.Items.Add("Wtorek");
            lb1.Items.Add("Środa");
            lb1.Items.Add("Czwartek");
            lb1.Items.Add("Piątek");
            lb1.Items.Add("Sobota");

            cb1.Items.Add("AM");
            cb1.Items.Add("PM");

            cb1.SelectedIndex = cb1.FindStringExact("AM");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Object obj in lb1.SelectedItems)
            {
                string t = cb1.Text;
                string info = obj.ToString() + " - czas" + t.ToString();
                MessageBox.Show(info);
            }
        }
    }
}
