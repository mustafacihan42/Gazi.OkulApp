using OkulApp.MODEL;
using System;
using System.Data.SqlClient;

namespace OkulApp.BLL//business logic layer
{
    public class OgrenciBl
    {
       public bool OgrenciEkle(Ogrenci ogr)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            try
            {
                using (cn = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=OkulDb;Integrated Security=true"))
                {
                    using (cmd = new SqlCommand($"Insert into tblOgrenciler (Ad,Soyad,Numara) values(@ad,@soyad,@numara)", cn))
                    {
                        SqlParameter[] p = {
                    new SqlParameter("@ad",ogr.ad),
                    new SqlParameter("@soyad",ogr.soyad),
                    new SqlParameter("@numara",ogr.numara)
                       };
                        cmd.Parameters.AddRange(p);
                        cn.Open();
                        int sonuc = cmd.ExecuteNonQuery();
                        return sonuc > 0;
                    }
                }
            }

            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //if (cn !=null & cn.State!= ConnectionState.Closed)
                //{
                // cn.Close();
                // cn.Dispose();
                // }

            }

        }
    }
}
