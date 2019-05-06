using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojistik.Core
{
    public class Firma
    {
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; }
        public bool AktifMi { get; set; }
        
        public virtual ICollection<Kayit> Kayit { get; set; }

    }
}
