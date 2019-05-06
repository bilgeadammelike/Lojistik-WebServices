using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojistik.Core
{
    public class Sefer
    {
        public int SeferId { get; set; }
        public int GemiId { get; set; }
        public int LimanId { get; set; }


        [ForeignKey("GemiId")]
        public virtual Gemi Gemi { get; set; }
        [ForeignKey("LimanId")]
        public virtual Liman Liman { get; set; }

    }
}
