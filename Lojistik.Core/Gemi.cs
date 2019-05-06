using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojistik.Core
{
    [Table("BizimGemi")]
   public class Gemi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name ="Geminin Kodu")]
        public string GemiAdi { get; set; }
        public decimal Tonaj { get; set; }
        public decimal Boyut { get; set; }
        public bool AktifMi { get; set; }

        [NotMapped]
        public string Hede { get; set; }

        public virtual ICollection<Sefer> Sefer { get; set; }
    }
}
