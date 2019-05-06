using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojistik.Core
{
    public class Kayit
    {
        public int KayitId { get; set; }
        public int FirmaId { get; set; }
        public decimal TonBilgisi { get; set; }
        public int SeferId { get; set; }

        [ForeignKey("FirmaId")]
        public virtual Firma Firma { get; set; }

        [ForeignKey("SeferId")]
        public virtual Sefer Sefer { get; set; }
    }
}
