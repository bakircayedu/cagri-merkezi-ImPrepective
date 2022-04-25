using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari
{
    class Customer:IEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }

        public Type MusteriTipi { get; set; }
    }
}
