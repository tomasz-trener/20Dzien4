namespace P06ZadaniePogoda
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.ofdPliki = new System.Windows.Forms.OpenFileDialog();
            this.btnPodajTemperature = new System.Windows.Forms.Button();
            this.lblRaport = new System.Windows.Forms.Label();
            this.pbCloud = new System.Windows.Forms.PictureBox();
            this.pbSnow = new System.Windows.Forms.PictureBox();
            this.pbSun = new System.Windows.Forms.PictureBox();
            this.pbObrazek = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(12, 37);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(186, 21);
            this.cbMiasta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj miasto";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(123, 8);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 2;
            this.btnWczytaj.Text = "Wczytaj plik";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // ofdPliki
            // 
            this.ofdPliki.FileName = "openFileDialog1";
            // 
            // btnPodajTemperature
            // 
            this.btnPodajTemperature.Location = new System.Drawing.Point(12, 64);
            this.btnPodajTemperature.Name = "btnPodajTemperature";
            this.btnPodajTemperature.Size = new System.Drawing.Size(185, 23);
            this.btnPodajTemperature.TabIndex = 3;
            this.btnPodajTemperature.Text = "Podaj temeperature";
            this.btnPodajTemperature.UseVisualStyleBackColor = true;
            this.btnPodajTemperature.Click += new System.EventHandler(this.btnPodajTemperature_Click);
            // 
            // lblRaport
            // 
            this.lblRaport.AutoSize = true;
            this.lblRaport.Location = new System.Drawing.Point(13, 104);
            this.lblRaport.Name = "lblRaport";
            this.lblRaport.Size = new System.Drawing.Size(35, 13);
            this.lblRaport.TabIndex = 4;
            this.lblRaport.Text = "label2";
            // 
            // pbCloud
            // 
            this.pbCloud.Image = global::P06ZadaniePogoda.Properties.Resources.clouds;
            this.pbCloud.Location = new System.Drawing.Point(54, 104);
            this.pbCloud.Name = "pbCloud";
            this.pbCloud.Size = new System.Drawing.Size(47, 47);
            this.pbCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloud.TabIndex = 7;
            this.pbCloud.TabStop = false;
            this.pbCloud.Visible = false;
            // 
            // pbSnow
            // 
            this.pbSnow.Image = global::P06ZadaniePogoda.Properties.Resources.snow;
            this.pbSnow.Location = new System.Drawing.Point(54, 104);
            this.pbSnow.Name = "pbSnow";
            this.pbSnow.Size = new System.Drawing.Size(47, 47);
            this.pbSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSnow.TabIndex = 6;
            this.pbSnow.TabStop = false;
            this.pbSnow.Visible = false;
            // 
            // pbSun
            // 
            this.pbSun.Image = global::P06ZadaniePogoda.Properties.Resources.sun;
            this.pbSun.Location = new System.Drawing.Point(54, 104);
            this.pbSun.Name = "pbSun";
            this.pbSun.Size = new System.Drawing.Size(47, 47);
            this.pbSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSun.TabIndex = 5;
            this.pbSun.TabStop = false;
            this.pbSun.Visible = false;
            // 
            // pbObrazek
            // 
            this.pbObrazek.Location = new System.Drawing.Point(146, 104);
            this.pbObrazek.Name = "pbObrazek";
            this.pbObrazek.Size = new System.Drawing.Size(51, 47);
            this.pbObrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbObrazek.TabIndex = 8;
            this.pbObrazek.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 206);
            this.Controls.Add(this.pbObrazek);
            this.Controls.Add(this.pbCloud);
            this.Controls.Add(this.pbSnow);
            this.Controls.Add(this.pbSun);
            this.Controls.Add(this.lblRaport);
            this.Controls.Add(this.btnPodajTemperature);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMiasta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.OpenFileDialog ofdPliki;
        private System.Windows.Forms.Button btnPodajTemperature;
        private System.Windows.Forms.Label lblRaport;
        private System.Windows.Forms.PictureBox pbSun;
        private System.Windows.Forms.PictureBox pbSnow;
        private System.Windows.Forms.PictureBox pbCloud;
        private System.Windows.Forms.PictureBox pbObrazek;
    }
}

