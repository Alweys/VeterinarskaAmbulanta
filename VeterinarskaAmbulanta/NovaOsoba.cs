using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace VeterinarskaAmbulanta
{
    public partial class NovaOsoba : Form
    {
        private string connStr = @"server=DESKTOP-D4RT3\SQLEXPRESS;uid=sa;pwd=Radijator1;database=VeterinarskaAmbulanta;connection timeout=30";
        private Form1 mainForm;

        public NovaOsoba(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connStr);
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("insert into Osoba(Ime, Prezime, OIB) values ('" 
                    + textBox_Ime.Text + "', '" + textBox_Prezime.Text + "', '" + textBox_OIB.Text + "')", myConnection);
                myCommand.ExecuteNonQuery();
                COsoba.dodajNovuOsobu(textBox_Ime.Text, textBox_Prezime.Text, textBox_OIB.Text.ToCharArray());
                textBox_Ime.Text = "";
                textBox_Prezime.Text = "";
                textBox_OIB.Text = "";
                mainForm.initOsobe();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            try
            {
                myConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
