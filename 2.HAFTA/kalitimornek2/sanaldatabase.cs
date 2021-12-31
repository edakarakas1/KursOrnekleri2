using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitimornek2
{
    public static class sanaldatabase
    {
        private static ArrayList db = new ArrayList();
        public static void yeniUrunEkle(baseclass data)
        {
            if (data !=null&& !string.IsNullOrEmpty(data.Barkod))
            {
                db.Add(data);

            }
        }
        public static bool dbBarkodKontrol(string barkod)
        {
            bool kontrolislemi = false;
            if (db!=null && db.Count>0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    baseclass bc = (baseclass)db[i];
                    if (bc.Barkod==barkod)
                    {
                        kontrolislemi = true;

                    }
                }
            }
            return kontrolislemi;
        }
    }
}
