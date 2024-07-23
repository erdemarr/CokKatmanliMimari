using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entity;

namespace CokKatmanliMimari
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        OgrenciBL OgrenciIslemleri = new OgrenciBL();
        OgretmenBL OgretmenIslemleri = new OgretmenBL();
        private void btnOgretmenKaydet_Click(object sender, EventArgs e)
        {
            int OgretmenID = Convert.ToInt32(listBox1.SelectedValue);
            int sonuc = OgrenciIslemleri.OgrenciEkle(txtAdi.Text, txtSoyAdi.Text, txtNo.Text, OgretmenID);
            MessageBox.Show(sonuc + "Öğrenci kayıt edildi.");
        }
        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            OgretmenleriGetir();
        }
        void OgretmenleriGetir()
        {
            List<Ogretmen> Ogretmenler = OgretmenIslemleri.OgretmenleriGetir();
            listBox1.DataSource = Ogretmenler;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "Adi";
        }
    }
}
