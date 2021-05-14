using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanlamaOyunuYazilimYapimi.Entitys
{
   public class SatinAlim
    {
        public int satinAlimID { get; set; }
        public int aliciID { get; set; }
        public int saticiID { get; set; }
        public string aliciAdi { get; set; }
        public string saticiAdi { get; set; }
        public string islemTarihi { get; set; }
        public string islemDetay { get; set; }
        public double islemTutari { get; set; }
        public double alicininKalanParasi { get; set; }
        public double urunBirimFiyati { get; set; }

    }
}
