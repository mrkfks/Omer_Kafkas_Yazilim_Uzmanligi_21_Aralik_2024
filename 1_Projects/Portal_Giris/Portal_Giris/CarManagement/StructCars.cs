using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Yönetim_Sistemi
{
    public struct StructCars
    {
        public string Marka { get; set; }
        public string Tip { get; set; }
        public string Renk { get; set; }
        public int Yıl { get; set; }

        // Yapıcı (constructor) metot
        public StructCars(string marka, string tip, string renk, int yil)
        {
            this.Marka = marka;
            this.Tip = tip;
            this.Renk = renk;
            this.Yıl = yil;
        }
    }

}
