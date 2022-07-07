using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtad;
        private int ogrtbrnas;

        public int Ogrtid { get => ogrtid; set => ogrtid = value; }
        public string Ogrtad { get => ogrtad; set => ogrtad = value; }
        public int Ogrtbrnas { get => ogrtbrnas; set => ogrtbrnas = value; }
    }
}
