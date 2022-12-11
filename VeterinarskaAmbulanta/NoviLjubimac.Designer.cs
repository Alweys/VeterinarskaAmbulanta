namespace VeterinarskaAmbulanta
{
    partial class NoviLjubimac
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
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_GodinaProizvodnje = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Vrsta = new System.Windows.Forms.ComboBox();
            this.textBox_Naziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Osoba = new System.Windows.Forms.ComboBox();
            this.button_Dodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GodinaProizvodnje)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Godina proizvodnje:";
            // 
            // numericUpDown_GodinaProizvodnje
            // 
            this.numericUpDown_GodinaProizvodnje.Location = new System.Drawing.Point(125, 203);
            this.numericUpDown_GodinaProizvodnje.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDown_GodinaProizvodnje.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_GodinaProizvodnje.Name = "numericUpDown_GodinaProizvodnje";
            this.numericUpDown_GodinaProizvodnje.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_GodinaProizvodnje.TabIndex = 20;
            this.numericUpDown_GodinaProizvodnje.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Vrsta:";
            // 
            // comboBox_Vrsta
            // 
            this.comboBox_Vrsta.FormattingEnabled = true;
            this.comboBox_Vrsta.Location = new System.Drawing.Point(124, 174);
            this.comboBox_Vrsta.Name = "comboBox_Vrsta";
            this.comboBox_Vrsta.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Vrsta.TabIndex = 18;
            // 
            // textBox_Naziv
            // 
            this.textBox_Naziv.Location = new System.Drawing.Point(124, 145);
            this.textBox_Naziv.Name = "textBox_Naziv";
            this.textBox_Naziv.Size = new System.Drawing.Size(100, 23);
            this.textBox_Naziv.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Osoba:";
            // 
            // comboBox_Osoba
            // 
            this.comboBox_Osoba.FormattingEnabled = true;
            this.comboBox_Osoba.Location = new System.Drawing.Point(124, 116);
            this.comboBox_Osoba.Name = "comboBox_Osoba";
            this.comboBox_Osoba.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Osoba.TabIndex = 14;
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.Location = new System.Drawing.Point(88, 246);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(75, 23);
            this.button_Dodaj.TabIndex = 22;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.UseVisualStyleBackColor = true;
            this.button_Dodaj.Click += new System.EventHandler(this.button_Dodaj_Click);
            // 
            // NoviLjubimac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 343);
            this.Controls.Add(this.button_Dodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_GodinaProizvodnje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Vrsta);
            this.Controls.Add(this.textBox_Naziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Osoba);
            this.Name = "NoviLjubimac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoviLjubimac";
            this.Load += new System.EventHandler(this.NoviLjubimac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GodinaProizvodnje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private NumericUpDown numericUpDown_GodinaProizvodnje;
        private Label label5;
        private ComboBox comboBox_Vrsta;
        private TextBox textBox_Naziv;
        private Label label4;
        private Label label1;
        private ComboBox comboBox_Osoba;
        private Button button_Dodaj;
    }
}