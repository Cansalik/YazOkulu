using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private int ogrenciid;
        private string ogrenciad;
        private string ogrencisoyad;
        private string ogrencinumara;
        private string ogrencifotograf;
        private double ogrencibakiye;
        private string ogrencisifre;

        public string OgrenciAd { get => ogrenciad; set => ogrenciad = value; }
        public string Ogrencisoyad { get => ogrencisoyad; set => ogrencisoyad = value; }
        public int OgrenciId { get => ogrenciid; set => ogrenciid = value; }
        public string OgrenciNumara { get => ogrencinumara; set => ogrencinumara = value; }
        public string OgrenciFotograf { get => ogrencifotograf; set => ogrencifotograf = value; }
        public double OgrenciBakiye { get => ogrencibakiye; set => ogrencibakiye = value; }
        public string Ogrencisifre { get => ogrencisifre; set => ogrencisifre = value; }
    }
}
