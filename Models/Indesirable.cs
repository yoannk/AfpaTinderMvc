using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AfpaTinderMvc.Models
{
    public class Indesirable
    {
        [Key]
        [Column("idIndesirable")]
        public int IdIndesirable { get; set; }

        public virtual Personne Personne { get; set; }
        public virtual Personne PersonneIndesirable { get; set; }
        public virtual MotifIndesirable MotifIndesirable { get; set; }
    }
}