using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.OkulApp
{
    public partial class frmOgretmenKayit : Form
    {
        public frmOgretmenKayit()
        {
            InitializeComponent();
        }
        
        //Dispose
        //Garbage collector

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                //var ogrenci = new Ogrenci();
                //ogrenci.ad = txtAd.Text.Trim();
               // ogrenci.soyad=txtSoyad.Text.Trim();
                //ogrenci.numara=txtNumara.Text.Trim();
                var obl = new OgretmenBl();
                bool sonuc =obl.OgretmenEkle(new Ogretmen { Ad=txtAd.Text.Trim
                (),Soyad=txtSoyad.Text.Trim(),TCNumara=txtTCNumara.Text.Trim()});
                MessageBox.Show(sonuc ? "Ekleme başarılı!" : "Ekleme başarısız!!");

            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                  case 2627:
                   MessageBox.Show("Bu Numara Daha Önce Kayıtlı");
                  break;
                 default:
                    MessageBox.Show("Veri Tabanı Hatası!");
                     break;
                 }
                throw;
                
            }
            catch (Exception)
            {
                      MessageBox.Show("Bir Hata Oluştu!");

             }
        }
    }
    
}

