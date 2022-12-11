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
    public partial class NoviLjubimac : Form
    {
        private string connStr = @"server=DESKTOP-D4RT3\SQLEXPRESS;uid=sa;pwd=Radijator1;database=VeterinarskaAmbulanta;connection timeout=30";
        private Form1 mainForm;
        public NoviLjubimac(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void NoviLjubimac_Load(object sender, EventArgs e)
        {
            foreach(COsoba o in COsoba.vratiOsobe())
                comboBox_Osoba.Items.Add(o);
            
            foreach(CVrsta v in CVrsta.vratiVrste())
                comboBox_Vrsta.Items.Add(v);
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            foreach (CLjubimac l in (comboBox_Osoba.SelectedItem as COsoba).vratiLjubimce())
            {
                if (textBox_Naziv.Text.Equals(l.vratiNaziv()) && comboBox_Vrsta.SelectedItem.Equals(l.vratiVrstu()))
                {
                    MessageBox.Show("Ljubimci iste vrste ne mogu imati isti Naziv!");
                    return;
                }
            }
            SqlConnection myConnection = new SqlConnection(connStr);
            try
            {
                myConnection.Open();
                string query = "insert into Ljubimac(Naziv, Vrsta_ID, Godina_proizvodnje, Uginuo) values ('"
                    + textBox_Naziv.Text + "', '" + (comboBox_Vrsta.SelectedItem as CVrsta).vratiID()
                    + "', '" + numericUpDown_GodinaProizvodnje.Value + "', 'False')";
                //MessageBox.Show(query);
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                myCommand.ExecuteNonQuery();
                CLjubimac.dodajNovogLjubimca(textBox_Naziv.Text, (comboBox_Vrsta.SelectedItem as CVrsta),
                    int.Parse(numericUpDown_GodinaProizvodnje.Value.ToString()), false);
                query = "insert into Vlasnistvo(Vlasnik_ID, Ljubimac_ID) values ('"
                    + (comboBox_Osoba.SelectedItem as COsoba).vratiID() + "', '"
                    + (CLjubimac.getIndexID()) + "')";
                //MessageBox.Show(query);
                myCommand = new SqlCommand(query, myConnection);
                myCommand.ExecuteNonQuery();
                comboBox_Osoba.SelectedItem = null;
                textBox_Naziv.Text = "";
                comboBox_Vrsta.SelectedItem = null;
                numericUpDown_GodinaProizvodnje.Value = 2000;
                mainForm.initLjubimci();
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
