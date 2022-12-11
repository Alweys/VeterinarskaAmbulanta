using System.Data.SqlClient;
using System.Diagnostics;

namespace VeterinarskaAmbulanta
{
    public partial class Form1 : Form
    {
        private string connStr = @"server=DESKTOP-D4RT3\SQLEXPRESS;uid=sa;pwd=Radijator1;database=VeterinarskaAmbulanta;connection timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void EnabledPanelContents(Panel panel, bool enabled)
        {
            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Enabled = enabled;
            }
        }

        public void initOsobe()
        {
            COsoba.obrisiOsobe();
            comboBox_Osoba.Items.Clear();
            SqlConnection myConnection = new SqlConnection(connStr);
            try
            {
                myConnection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from Osoba", myConnection);
                myReader = myCommand.ExecuteReader();
                int i = 0;
                while (myReader.Read())
                {
                    COsoba.dodajOsobu(int.Parse(myReader["ID"].ToString()), myReader["Ime"].ToString(), myReader["Prezime"].ToString(), myReader["OIB"].ToString().ToCharArray());
                    i++;
                }
                COsoba.setIndexID(i + 1);

                myReader.Close();

                foreach(COsoba o in COsoba.vratiOsobe())
                {
                    comboBox_Osoba.Items.Add(o);
                }
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
        public void initLjubimci()
        {
            CLjubimac.obrisiLjubimce();
            foreach(COsoba o in COsoba.vratiOsobe())
            {
                o.obrisiLjubimce();
            }
            comboBox_Ljubimac.Items.Clear();
            SqlConnection myConnection = new SqlConnection(connStr);
            try
            {
                myConnection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from Ljubimac inner join Vrsta on Ljubimac.Vrsta_ID = Vrsta.ID", myConnection);
                myReader = myCommand.ExecuteReader();
                int i = 0;

                while (myReader.Read())
                {
                    CVrsta vrsta = null;
                    foreach(CVrsta v in CVrsta.vratiVrste())
                    {
                        if(v.vratiID().ToString().Equals((myReader["Vrsta_ID"].ToString())))
                        {
                            vrsta = v;
                            break;
                        }
                    }
                    CLjubimac.dodajLjubimca(int.Parse(myReader["ID"].ToString()), myReader["Naziv"].ToString(), vrsta, int.Parse(myReader["Godina_proizvodnje"].ToString()), bool.Parse(myReader["Uginuo"].ToString()));
                    i++;
                }
                CLjubimac.setIndexID(i + 1);

                myReader.Close();

                foreach (COsoba o in COsoba.vratiOsobe())
                {
                    myReader = null;
                    myCommand = new SqlCommand("select Ljubimac_ID from Vlasnistvo where Vlasnik_ID = '" + o.vratiID() + "'", myConnection);
                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        foreach (CLjubimac l in CLjubimac.vratiLjubimce())
                        {
                            if (myReader["Ljubimac_ID"].ToString().Equals(l.vratiID().ToString()))
                            {
                                o.dodajLjubimca(l);
                            }
                        }
                    }
                    myReader.Close();
                }

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

        public void initVrste()
        {
            CVrsta.obrisiVrste();
            comboBox_Vrsta.Items.Clear();
            SqlConnection myConnection = new SqlConnection(connStr);
            try
            {
                myConnection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("select * from Vrsta", myConnection);
                myReader = myCommand.ExecuteReader();

                int i = 0;
                while (myReader.Read())
                {
                    CVrsta.dodajVrstu(int.Parse(myReader["ID"].ToString()), myReader["Naziv"].ToString());
                    i++;
                }
                CVrsta.setIndexID(i + 1);
                foreach (CVrsta v in CVrsta.vratiVrste())
                {
                    comboBox_Vrsta.Items.Add(v);
                }
                myReader.Close();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            EnabledPanelContents(panel1, false);
            initOsobe();
            initVrste();
            initLjubimci();
        }

        private void ucitajLjubimce()
        {
            comboBox_Ljubimac.Text = "";
            textBox_ID.Text = "";
            textBox_Naziv.Text = "";
            comboBox_Vrsta.SelectedItem = null;
            numericUpDown_GodinaProizvodnje.Value = 2000;
            checkBox_Uginuo.Checked = false;
            comboBox_Ljubimac.Items.Clear();
            EnabledPanelContents(panel1, false);

            foreach (CLjubimac l in (comboBox_Osoba.SelectedItem as COsoba).vratiLjubimce())
            {
                if(l.Ziv())
                    comboBox_Ljubimac.Items.Add(l);
            }
        }

        private void comboBox_Osoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajLjubimce();
        }

        private void comboBox_Ljubimac_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_ID.Text = (comboBox_Ljubimac.SelectedItem as CLjubimac).vratiID().ToString();
            textBox_Naziv.Text = (comboBox_Ljubimac.SelectedItem as CLjubimac).vratiNaziv().ToString();
            comboBox_Vrsta.SelectedItem = (comboBox_Ljubimac.SelectedItem as CLjubimac).vratiVrstu();
            numericUpDown_GodinaProizvodnje.Value = (comboBox_Ljubimac.SelectedItem as CLjubimac).vratiGodinuProizvodnje();
            checkBox_Uginuo.Checked = (comboBox_Ljubimac.SelectedItem as CLjubimac).vratiUginuo();
            EnabledPanelContents(panel1, true);
        }

        private void button_Spremi_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(connStr);
            try
            {
                myConnection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("update Ljubimac set Naziv = '" + textBox_Naziv.Text + "', Vrsta_ID = '"
                    + (comboBox_Vrsta.SelectedItem as CVrsta).vratiID() + "', Godina_proizvodnje = '"
                    + numericUpDown_GodinaProizvodnje.Value + "', Uginuo = '"
                    + checkBox_Uginuo.Checked + "' where ID = "
                    + (comboBox_Ljubimac.SelectedItem as CLjubimac).vratiID(), myConnection);
                myCommand.ExecuteNonQuery();

                initLjubimci();
                ucitajLjubimce();
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

        private void dodajOsobuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaOsoba form = new NovaOsoba(this);
            form.Show();
        }

        private void dodajVrstuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaVrsta form = new NovaVrsta(this);
            form.Show();
        }

        private void dodajLjubimcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoviLjubimac form = new NoviLjubimac(this);
            form.Show();
        }
    }
}