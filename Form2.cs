using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CMS__Calibration_Management_System_
{
    public partial class Form2 : Form
    {
        public void Kayit()
        {
            int Counter = 0;
            foreach (TextBox x in this.groupBox1.Controls.OfType<TextBox>())
            {
                if (x.Text != "")
                {
                    Counter++;
                    if (Counter == 8)
                    {
                        Kaydet.Enabled = true;
                    }
                    else
                    {
                        Kaydet.Enabled = false;
                    }
                }
            }
        }
        #region
        private void İstek_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Cihaz_adi_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Marka__KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Model__KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Serino_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Caldate_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Cal_comp_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        private void Capacity_KeyUp(object sender, KeyEventArgs e)
        {
            Kayit();
        }

        #endregion

        readonly OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\etanik\Desktop\Database1.mdb");
        private readonly OleDbCommand emir = new OleDbCommand();

        public Form2()
        {

            InitializeComponent();
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            {
                dataGridView1.Rows.Add(12);
              
                double[] frekans = { 5, 10, 20, 31.5, 50, 80, 100, 160, 315, 500, 1000, 2000, 3150 };
                int i = 0;
                foreach (double sayi in frekans)

                {
                    dataGridView1[0, i].Value = sayi;
                    i++;
                }

                /*dataGridView1.AllowUserToAddRows = false;*/
            }
        }
        private void Kaydet_Click_1(object sender, EventArgs e)
        {
            accelerometer yeniivmeolcer = new accelerometer
            {
                calibrationdate = caldate.Text,
                serialnumber = serino.Text,
                sensitivity = capacity.Text,
                marka = marka_.Text,
                model = model_.Text,
                rfq = istek.Text,
                chz = cihaz_adi.Text,
                calyapan = cal_comp.Text
            };

            DialogResult dr = MessageBox.Show(
            "Warning: when importing data into the Access database, ensure that the field columns match Access's fields or the file may become corrupt. Do you still wish to proceed?", "Import caution",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dr == DialogResult.OK)
            {
                try
                {
                    emir.Connection = baglanti;
                    baglanti.Open();
                    emir.CommandText =
                                       "INSERT INTO CihazBilgileri ( İstekNumarası, Cihaz, Marka, Model, SeriNo, KalibrasyonTarihi, KalibrasyonuYapan, Kapasite) " +
                                       "VALUES('" + yeniivmeolcer.rfq + "','" + yeniivmeolcer.chz + "','" + yeniivmeolcer.marka + "','" + yeniivmeolcer.model + "','" +
                                        yeniivmeolcer.serialnumber + "','" + yeniivmeolcer.calibrationdate + "','" + yeniivmeolcer.calyapan + "','" + yeniivmeolcer.sensitivity + "')";
                    emir.ExecuteNonQuery();

                    string tableName = "acc" + yeniivmeolcer.serialnumber + "_" + yeniivmeolcer.calibrationdate;
                    string columns = "[Frekans] Text, [UygulananIvme] Text , [HassasiyetKatsayisi] Text, [Sapma] Text, [StandartSapma] Text, [FazAcisi] Text";
                    emir.Connection = baglanti;
                    emir.CommandText = "CREATE TABLE " + tableName + "(" + columns + ")";
                    emir.ExecuteNonQuery();

                    emir.CommandText =
                                        "INSERT INTO " + tableName + "(Frekans, UygulananIvme, HassasiyetKatsayisi, Sapma, StandartSapma, FazAcisi)"
                                        + "VALUES(@Frekans, @UygulananIvme, @HassasiyetKatsayisi,@Sapma,@StandartSapma,@FazAcisi)";

                    for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                    {
                        emir.Parameters.Clear();
                        emir.Parameters.AddWithValue("@Frekans", Convert.ToDouble(dataGridView1[0, j].Value));
                        emir.Parameters.AddWithValue("@Uygulananİvme", Convert.ToDouble(dataGridView1[1, j].Value));
                        emir.Parameters.AddWithValue("@HassasiyetKatsayisi", Convert.ToDouble(dataGridView1[2, j].Value));
                        emir.Parameters.AddWithValue("@Sapma", Convert.ToDouble(dataGridView1[3, j].Value));
                        emir.Parameters.AddWithValue("@StandartSapma", Convert.ToDouble(dataGridView1[4, j].Value));
                        emir.Parameters.AddWithValue("@FazAcisi", Convert.ToDouble(dataGridView1[5, j].Value));

                        emir.ExecuteNonQuery();
                    }       
                }

                catch (OleDbException ex)
                {
                    MessageBox.Show("Import error: " + ex);
                }

                dataGridView1.Rows.Clear();

                foreach (Control ctrl in groupBox1.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        (ctrl as TextBox).Text = "";

                        baglanti.Close();

                        dataGridView1.Rows.Add(12);
                        double[] frekans = { 5, 10, 20, 31.5, 50, 80, 100, 160, 315, 500, 1000, 2000, 3150 };
                        int i = 0;
                        foreach (double sayi in frekans)
                        {
                            dataGridView1[0, i].Value = sayi;
                            i++;
                        }
                    }
                }
            }
        }
               
    }
}
