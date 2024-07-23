using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Entity;
using System.Data.SqlClient;

namespace BL
{
    public class OgretmenBL
    {
        DAL.DAL dl = new DAL.DAL();
        public int OgretmenEkle(string Adi, string SoyAdi, string Bransi)
        {
            dl.InputParametreEkle("@Adi", Adi);
            dl.InputParametreEkle("@SoyAdi", SoyAdi);
            dl.InputParametreEkle("@Bransi", Bransi);
            int sonuc = dl.EkleSilGuncelle("sp_OgretmenEkle", CommandType.StoredProcedure);

            return sonuc;
        }

        public List<Ogretmen> OgretmenleriGetir()
        {
            SqlDataReader dr = dl.DRVeriCek("sp_OgretmenleriCek", CommandType.StoredProcedure);

            if (dr.HasRows)
            {
                List<Ogretmen> Ogretmenler = new List<Ogretmen>();
                while (dr.Read())
                {
                    Ogretmen ogretmen = new Ogretmen { Adi = dr["Adi"].ToString(), Bransi = dr["Bransi"].ToString(), ID = Convert.ToInt32(dr["ID"].ToString()), SoyAdi = dr["SoyAdi"].ToString() };

                    Ogretmenler.Add(ogretmen);
                }

                return Ogretmenler;
            }
            return null;
        }
    }
}
