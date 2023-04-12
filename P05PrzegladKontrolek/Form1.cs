using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05PrzegladKontrolek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknieto kosz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Value += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://goo.gl/maps/5EwuYkb5RKZcR6gbA");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_LocationChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

        }

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("hej");
        }
    }
}
