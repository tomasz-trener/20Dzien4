using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaOkienkowa
{

    // tutaj będziemy pisać własny kod 
    // główną rolą tego pliku będzie obsługa zdarzeń 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPowitanie_Click(object sender, EventArgs e)
        {
            string s = "dzień dobry";

            MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPolicz_Click(object sender, EventArgs e)
        {
            int liczba1 = Convert.ToInt32(txtLiczba1.Text);
            int liczba2 = Convert.ToInt32(txtLiczba2.Text);
            int wynik = liczba1 + liczba2;

            txtWynik.Text = Convert.ToString(wynik);
        }
    }
}
