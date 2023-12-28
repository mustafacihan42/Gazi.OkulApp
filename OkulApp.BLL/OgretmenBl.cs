using OkulApp.MODEL;
using System;
using System.Data.SqlClient;

namespace OkulApp.BLL//business logic layer
{
    public class OgretmenBl
    {
       public bool OgretmenEkle(Ogretmen ogr)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            try
            {
                using (cn = new SqlConnection(@"Data source=.\SQLEXPRESS;Initial Catalog=OkulDb;Integrated Security=true"))
                {
                    using (cmd = new SqlCommand($"Insert into tblOgretmen (Ad,Soyad,TCNumara) values(@ad,@soyad,@TCnumara)", cn))
                    {
                        SqlParameter[] p = {
                    new SqlParameter("@Ad",ogr.Ad),
                    new SqlParameter("@Soyad",ogr.Soyad),
                    new SqlParameter("@TCNumara",ogr.TCNumara)
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
