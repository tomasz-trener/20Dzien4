﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08ZadanieFiltrowanieDanych
{
    public partial class Form1 : Form
    {
        ManagerZawodnikow mz = new ManagerZawodnikow();
        public Form1()
        {
            InitializeComponent();
        
            mz.WczytajZawodnikow();
            cbKraje.DataSource = mz.PodajKraje();

            
        }

        private void cbKraje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zaznaczonyKraj = (string)cbKraje.SelectedItem;

            if(zaznaczonyKraj != null)
            {
                lbDane.DataSource = mz.PodajZawodnikow(zaznaczonyKraj);
                lbDane.DisplayMember = "ImieNazwiskoKraj";

                double wzrost= mz.PodajSredniWzrost(zaznaczonyKraj);
                //lblSredniWzrost.Text = $"średni wzrost: {wzrost}";
                lblSredniWzrost.Text = string.Format("średni wzrost {0:0.00}",wzrost);
            }
        }
    }
}
