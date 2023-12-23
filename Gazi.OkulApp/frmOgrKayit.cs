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
    public partial class frmOgrKayit : Form
    {
        public frmOgrKayit()
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
                var obl = new OgrenciBl();
                bool sonuc =obl.OgrenciEkle(new Ogrenci { ad=txtAd.Text.Trim
                (),soyad=txtSoyad.Text.Trim(),numara=txtNumara.Text.Trim()});
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
    interface ITransfer
    {
        int EFT(string aliciiban, string gondereniban, double tutar);
        int Havale(string aliciiban, string gondereniban, double tutar,DateTime tarih);
    }
    class Transferislemleri : ITransfer
    {
        public int EFT(string aliciiban, string gondereniban, double tutar)
        {
            throw new NotImplementedException();
        }

        public int Havale(string aliciiban, string gondereniban, double tutar, DateTime tarih)
        {
            throw new NotImplementedException();
        }
    }
}
