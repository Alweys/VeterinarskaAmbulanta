namespace VeterinarskaAmbulanta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Osoba = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Ljubimac = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Spremi = new System.Windows.Forms.Button();
            this.checkBox_Uginuo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_GodinaProizvodnje = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Vrsta = new System.Windows.Forms.ComboBox();
            this.textBox_Naziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajOsobuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajVrstuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajLjubimcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GodinaProizvodnje)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Osoba
            // 
            this.comboBox_Osoba.FormattingEnabled = true;
            this.comboBox_Osoba.Location = new System.Drawing.Point(72, 36);
            this.comboBox_Osoba.Name = "comboBox_Osoba";
            this.comboBox_Osoba.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Osoba.TabIndex = 0;
            this.comboBox_Osoba.SelectedIndexChanged += new System.EventHandler(this.comboBox_Osoba_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Osoba:";
            // 
            // comboBox_Ljubimac
            // 
            this.comboBox_Ljubimac.FormattingEnabled = true;
            this.comboBox_Ljubimac.Location = new System.Drawing.Point(397, 36);
            this.comboBox_Ljubimac.Name = "comboBox_Ljubimac";
            this.comboBox_Ljubimac.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Ljubimac.TabIndex = 2;
            this.comboBox_Ljubimac.SelectedIndexChanged += new System.EventHandler(this.comboBox_Ljubimac_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ljubimac:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Spremi);
            this.panel1.Controls.Add(this.checkBox_Uginuo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDown_GodinaProizvodnje);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox_Vrsta);
            this.panel1.Controls.Add(this.textBox_Naziv);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Location = new System.Drawing.Point(275, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 169);
            this.panel1.TabIndex = 4;
            // 
            // button_Spremi
            // 
            this.button_Spremi.Location = new System.Drawing.Point(122, 144);
            this.button_Spremi.Name = "button_Spremi";
            this.button_Spremi.Size = new System.Drawing.Size(75, 23);
            this.button_Spremi.TabIndex = 9;
            this.button_Spremi.Text = "Spremi";
            this.button_Spremi.UseVisualStyleBackColor = true;
            this.button_Spremi.Click += new System.EventHandler(this.button_Spremi_Click);
            // 
            // checkBox_Uginuo
            // 
            this.checkBox_Uginuo.AutoSize = true;
            this.checkBox_Uginuo.Location = new System.Drawing.Point(122, 119);
            this.checkBox_Uginuo.Name = "checkBox_Uginuo";
            this.checkBox_Uginuo.Size = new System.Drawing.Size(65, 19);
            this.checkBox_Uginuo.TabIndex = 8;
            this.checkBox_Uginuo.Text = "Uginuo";
            this.checkBox_Uginuo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Godina proizvodnje:";
            // 
            // numericUpDown_GodinaProizvodnje
            // 
            this.numericUpDown_GodinaProizvodnje.Location = new System.Drawing.Point(123, 90);
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
            this.numericUpDown_GodinaProizvodnje.TabIndex = 6;
            this.numericUpDown_GodinaProizvodnje.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vrsta:";
            // 
            // comboBox_Vrsta
            // 
            this.comboBox_Vrsta.FormattingEnabled = true;
            this.comboBox_Vrsta.Location = new System.Drawing.Point(122, 61);
            this.comboBox_Vrsta.Name = "comboBox_Vrsta";
            this.comboBox_Vrsta.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Vrsta.TabIndex = 4;
            // 
            // textBox_Naziv
            // 
            this.textBox_Naziv.Location = new System.Drawing.Point(122, 32);
            this.textBox_Naziv.Name = "textBox_Naziv";
            this.textBox_Naziv.Size = new System.Drawing.Size(100, 23);
            this.textBox_Naziv.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(122, 3);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(100, 23);
            this.textBox_ID.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajOsobuToolStripMenuItem,
            this.dodajVrstuToolStripMenuItem,
            this.dodajLjubimcaToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // dodajOsobuToolStripMenuItem
            // 
            this.dodajOsobuToolStripMenuItem.Name = "dodajOsobuToolStripMenuItem";
            this.dodajOsobuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajOsobuToolStripMenuItem.Text = "Dodaj Osobu";
            this.dodajOsobuToolStripMenuItem.Click += new System.EventHandler(this.dodajOsobuToolStripMenuItem_Click);
            // 
            // dodajVrstuToolStripMenuItem
            // 
            this.dodajVrstuToolStripMenuItem.Name = "dodajVrstuToolStripMenuItem";
            this.dodajVrstuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajVrstuToolStripMenuItem.Text = "Dodaj Vrstu";
            this.dodajVrstuToolStripMenuItem.Click += new System.EventHandler(this.dodajVrstuToolStripMenuItem_Click);
            // 
            // dodajLjubimcaToolStripMenuItem
            // 
            this.dodajLjubimcaToolStripMenuItem.Name = "dodajLjubimcaToolStripMenuItem";
            this.dodajLjubimcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajLjubimcaToolStripMenuItem.Text = "Dodaj Ljubimca";
            this.dodajLjubimcaToolStripMenuItem.Click += new System.EventHandler(this.dodajLjubimcaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Ljubimac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Osoba);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ambulanta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GodinaProizvodnje)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox_Osoba;
        private Label label1;
        private ComboBox comboBox_Ljubimac;
        private Label label2;
        private Panel panel1;
        private TextBox textBox_ID;
        private Label label3;
        private TextBox textBox_Naziv;
        private Label label4;
        private ComboBox comboBox_Vrsta;
        private Label label5;
        private NumericUpDown numericUpDown_GodinaProizvodnje;
        private Label label6;
        private CheckBox checkBox_Uginuo;
        private Button button_Spremi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dodajToolStripMenuItem;
        private ToolStripMenuItem dodajOsobuToolStripMenuItem;
        private ToolStripMenuItem dodajVrstuToolStripMenuItem;
        private ToolStripMenuItem dodajLjubimcaToolStripMenuItem;
    }
}