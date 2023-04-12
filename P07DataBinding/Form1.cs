using P07DataBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy = mz.WczytajZawodnikow();

            lbDane.DataSource = zawodnicy; // wiązanie danych 
            lbDane.DisplayMember = "ImieNazwiskoKraj";

        }

        private void btnPodajTemperature_Click(object sender, EventArgs e)
        {
            // odczytaj zaznaczony element 
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            ManagerPogody mp = new ManagerPogody();
            double temp =  mp.PodajTemperature(zaznaczony.Kraj, "Celcjusz");
            MessageBox.Show(temp.ToString());
        }
    }
}
