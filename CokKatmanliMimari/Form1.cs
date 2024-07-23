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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgretmenKaydet_Click(object sender, EventArgs e)
        {
            int sonuc = OgretmenIslemleri.OgretmenEkle(txtAdi.Text, txtSoyAdi.Text, txtBransi.Text);
            MessageBox.Show(sonuc + "Öğretmen eklenmiştir.");
        }
        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            OgrenciEkle oe = new OgrenciEkle();
            oe.ShowDialog();
        }
    }
}
