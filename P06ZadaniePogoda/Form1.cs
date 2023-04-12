using P06ZadaniePogoda.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06ZadaniePogoda
{
    public partial class Form1 : Form
    {
        private string sciezkaMiasta = "miasta.txt"; //const

        public Form1()
        {
            InitializeComponent();
            wczytajMiasta();
        }

        private void wczytajMiasta()
        {
            string[] miasta= File.ReadAllLines(sciezkaMiasta);
            cbMiasta.Items.Clear();

            //mozemy w petli uzupelnic elementy tak samo
            // jak w listbox 

            // zamiast tego mamy jedną metodę:
            cbMiasta.Items.AddRange(miasta);
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ofdPliki.Filter = "Pliki tekstowe (*.txt)|*.txt|Pliki exe|*.exe";
            if (ofdPliki.ShowDialog() == DialogResult.OK)
            {
                sciezkaMiasta = ofdPliki.FileName;
                wczytajMiasta();
            }
            
        }

        private void btnPodajTemperature_Click(object sender, EventArgs e)
        {
            ManagerPogody mp = new ManagerPogody();
            string wybraneMiasto = cbMiasta.Text;

            double temp= mp.PodajTemperature(wybraneMiasto, "Celcjusz");
            lblRaport.Text = Convert.ToString(temp);

            pbSnow.Visible = false;
            pbCloud.Visible = false;
            pbSun.Visible = false;

            if (temp < 0)
            {
                pbSnow.Visible = true;
                pbObrazek.Image = Resources.snow;
               // pbObrazek.ImageLocation = "sciezkaDoPliku..";
            }
            else if(temp < 11)
            {
                pbCloud.Visible = true;
                pbObrazek.Image = Resources.clouds;
            }
            else
            {
                pbSun.Visible = true;
                pbObrazek.Image = Resources.sun;
            }
        }
    }
}
