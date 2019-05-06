using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojistik.Core
{
    public class Liman
    {
        public int LimanId { get; set; }
        public string LimanAdi { get; set; }

        public virtual ICollection<Sefer> Sefer { get; set; }
    }
}
