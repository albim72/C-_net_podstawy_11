using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wiadmosci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if(chkIst.Checked == true)
            {
                msg = "bardzo istotna wiadomość: abcx\n";
            }
            if(chkal.Checked == true)
            {
                msg += "wiadmość typu ALERT!\n";
            }
            if(chkinf.Checked == true)
            {
                msg += "wiadomość -> informacja dodatkowa!\n";
            }

            if(msg.Length > 0)
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Nie znaleziono żadnej wiadmości...");

            }
        }
    }
}
