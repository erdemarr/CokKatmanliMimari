using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data.SqlClient;

namespace BL
{
    public class OgrenciBL
    {
        DAL.DAL dl = new DAL.DAL();
        public int OgrenciEkle(string Adi, string SoyAdi, string No, int OgretmenID)
        {
            dl.InputParametreEkle("@Adi", Adi);
            dl.InputParametreEkle("@SoyAdi", SoyAdi);
            dl.InputParametreEkle("@No", No);
            dl.InputParametreEkle("@OgretmenID", OgretmenID);
            int sonuc = dl.EkleSilGuncelle("sp_OgrenciEkle", CommandType.StoredProcedure);

            return sonuc;
        }
    }
}
