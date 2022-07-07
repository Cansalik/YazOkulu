using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ogrenciad;
        private string ogrencisoyad;
        private int ogrenciid;
        private string ogrencinumara;
        private string ogrencifotograf;
        private double ogrencibakiye;
        private string ogrencisifre;

        public string Ad { get => ogrenciad; set => ogrenciad = value; }
        public string Ogrencisoyad { get => ogrencisoyad; set => ogrencisoyad = value; }
        public int Id { get => ogrenciid; set => ogrenciid = value; }
        public string Numara { get => ogrencinumara; set => ogrencinumara = value; }
        public string Fotograf { get => ogrencifotograf; set => ogrencifotograf = value; }
        public double Bakiye { get => ogrencibakiye; set => ogrencibakiye = value; }
        public string Ogrencisifre { get => ogrencisifre; set => ogrencisifre = value; }
    }
}
