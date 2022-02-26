using Newtonsoft.Json;
using SekillerDunyasi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SekillerDunyasi
{
    public partial class Form1 : Form
    {
        BindingList<Sekil> sekiller = new BindingList<Sekil>();


        #region MyRegion
        //Dikdortgen d;
        //Elips elips; 
        #endregion
        public Form1()
        {
            InitializeComponent();
            VerileriOku();
            sekiller.ListChanged += Sekiller_ListChanged;
            lstSekiller.DataSource = sekiller;
            cmbSekilSec.SelectedIndex = 0;
            #region MyRegion
            //d = new Dikdortgen(20,30,200,200,Color.Purple);
            //#region özellikler
            ////d.Genislik = 200;
            ////d.Yukseklik = 200;
            ////d.X = 20;
            ////d.Y = 30;
            ////d.Renk = Color.Purple; 
            //#endregion
            //MessageBox.Show(d.ToString());
            //elips = new Elips(200,300,100,100,Color.Green); 
            #endregion


        }


        private void Sekiller_ListChanged(object sender, ListChangedEventArgs e)
        {
            pnlCizim.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            #region Çizdirme
            //d.Ciz(e.Graphics);
            //elips.Ciz(e.Graphics); 
            #endregion
        }

        private void pbRenk_Click(object sender, EventArgs e)
        {
            cdirenk.ShowDialog();
            pbRenk.BackColor = cdirenk.Color;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sekil yeni;
            if (cmbSekilSec.SelectedIndex == 0)
                yeni = new Dikdortgen();
            else
                yeni = new Elips();

            yeni.X = (int)nudX.Value;
            yeni.Y = (int)nudY.Value;
            yeni.Yukseklik = (int)nudYuk.Value;
            yeni.Genislik = (int)nudGen.Value;
            yeni.Renk = cdirenk.Color;
            sekiller.Add(yeni);
            lstSekiller.SelectedIndex = -1;

        }

        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            foreach (Sekil sekil in sekiller)
            {
                sekil.Ciz(e.Graphics);
            }
        }

        private void lstSekiller_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstSekiller.SelectedIndex != -1)
            {
                sekiller.Remove(lstSekiller.SelectedItem as Sekil);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;

            if (sid != -1 && sid != 0)
            {
                (sekiller[sid], sekiller[sid - 1]) = (sekiller[sid - 1], sekiller[sid]);

                lstSekiller.SelectedIndex = --sid;
                lstSekiller.Focus();
            }
        }

        private void lstSekiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            if (sid == -1)
                return;

            btnUp.Enabled = btnDown.Enabled = true;
            tbSaydamlik.Value = sekiller[sid].Saydamlik;
            if (sid == 0)
            {
                btnUp.Enabled = false;
            }
            else if (sid == sekiller.Count - 1)
            {
                btnDown.Enabled = false;
            }
            else
            {
                btnUp.Enabled = true;
                btnDown.Enabled = true;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;

            if (sid != -1 && sid != sekiller.Count - 1)
            {
                (sekiller[sid], sekiller[sid + 1]) = (sekiller[sid + 1], sekiller[sid]);

                lstSekiller.SelectedIndex = ++sid;
                lstSekiller.Focus();
            }
        }
        private void tbSaydamlik_Scroll(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;

            if (sid == -1)
                return;

            sekiller[sid].SaydamligiDegistir(tbSaydamlik.Value);
            pnlCizim.Refresh();
        }

        private void pnlCizim_MouseClick(object sender, MouseEventArgs e)
        {
            nudX.Value = e.Location.X;
            nudY.Value = e.Location.Y;
        }

        private void btnPaneliTemizle_Click(object sender, EventArgs e)
        {
            sekiller.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }


        private void VerileriKaydet()
        {
            // Serialization
            string toJson = JsonConvert.SerializeObject(sekiller, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            File.WriteAllText("veri.json", toJson);
        }
        private void VerileriOku()
        {
            // Deserialization
            string json = File.ReadAllText("veri.json");
            sekiller = JsonConvert.DeserializeObject<BindingList<Sekil>>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sekiller.Remove(lstSekiller.SelectedItem as Sekil);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            if (sid == -1)
                return;

            Sekil guncellenen = sekiller[sid];

            guncellenen.X = (int)nudX.Value;
            guncellenen.Y = (int)nudY.Value;
            guncellenen.Yukseklik = (int)nudYuk.Value;
            guncellenen.Genislik = (int)nudGen.Value;
            guncellenen.Renk = cdirenk.Color;
            guncellenen.Saydamlik = tbSaydamlik.Value;
            lstSekiller.Refresh();
            pnlCizim.Refresh();
            

        }
    }
}
