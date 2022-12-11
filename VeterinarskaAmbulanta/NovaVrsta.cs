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
    public partial class NovaVrsta : Form
    {
        private string connStr = @"server=DESKTOP-D4RT3\SQLEXPRESS;uid=sa;pwd=Radijator1;database=VeterinarskaAmbulanta;connection timeout=30";
        private Form1 mainForm;
        public NovaVrsta(Form1 form)
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
                SqlCommand myCommand = new SqlCommand("insert into Vrsta(Naziv) values ('"
                    + textBox_Naziv.Text + "')", myConnection);
                myCommand.ExecuteNonQuery();
                CVrsta.dodajNovuVrstu(textBox_Naziv.Text);
                textBox_Naziv.Text = "";
                mainForm.initVrste();
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
