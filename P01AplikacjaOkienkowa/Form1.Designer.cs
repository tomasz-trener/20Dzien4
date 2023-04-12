namespace P01AplikacjaOkienkowa
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
            this.btnPowitanie = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPolicz = new System.Windows.Forms.Button();
            this.txtLiczba1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLiczba2 = new System.Windows.Forms.TextBox();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.lblWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPowitanie
            // 
            this.btnPowitanie.Location = new System.Drawing.Point(12, 32);
            this.btnPowitanie.Name = "btnPowitanie";
            this.btnPowitanie.Size = new System.Drawing.Size(134, 61);
            this.btnPowitanie.TabIndex = 0;
            this.btnPowitanie.Text = "Powitanie";
            this.btnPowitanie.UseVisualStyleBackColor = true;
            this.btnPowitanie.Click += new System.EventHandler(this.btnPowitanie_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPolicz
            // 
            this.btnPolicz.Location = new System.Drawing.Point(334, 32);
            this.btnPolicz.Name = "btnPolicz";
            this.btnPolicz.Size = new System.Drawing.Size(134, 57);
            this.btnPolicz.TabIndex = 2;
            this.btnPolicz.Text = "Policz";
            this.btnPolicz.UseVisualStyleBackColor = true;
            this.btnPolicz.Click += new System.EventHandler(this.btnPolicz_Click);
            // 
            // txtLiczba1
            // 
            this.txtLiczba1.Location = new System.Drawing.Point(334, 122);
            this.txtLiczba1.Name = "txtLiczba1";
            this.txtLiczba1.Size = new System.Drawing.Size(134, 20);
            this.txtLiczba1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Podaj liczbę 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Podaj liczbę 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLiczba2
            // 
            this.txtLiczba2.Location = new System.Drawing.Point(334, 168);
            this.txtLiczba2.Name = "txtLiczba2";
            this.txtLiczba2.Size = new System.Drawing.Size(134, 20);
            this.txtLiczba2.TabIndex = 5;
            // 
            // txtWynik
            // 
            this.txtWynik.Location = new System.Drawing.Point(334, 211);
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.Size = new System.Drawing.Size(134, 20);
            this.txtWynik.TabIndex = 7;
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(337, 195);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(37, 13);
            this.lblWynik.TabIndex = 8;
            this.lblWynik.Text = "Wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 320);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.txtWynik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLiczba2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLiczba1);
            this.Controls.Add(this.btnPolicz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPowitanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPowitanie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPolicz;
        private System.Windows.Forms.TextBox txtLiczba1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLiczba2;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.Label lblWynik;
    }
}

