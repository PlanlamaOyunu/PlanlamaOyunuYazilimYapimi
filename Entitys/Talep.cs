using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanlamaOyunuYazilimYapimi.Entitys
{
    public class Talep//para talep entity si
    {
        public int talepId { get; set; }
        public int kullaniciId { get; set; }
        public string talepTarihi { get; set; }
        public string kullaniciAdi { get; set; }
        public double talepMiktari { get; set; }
    }
}
