using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AfpaTinderMvc.Models
{
    public class Loisir
    {
        public Loisir()
        {
            Personnes = new HashSet<Personne>();
        }

        [Key]
        [Column("idLoisir")]
        public int IdLoisir { get; set; }

        [StringLength(50)]
        [Required]
        [Column("nom")]
        public string Nom { get; set; }

        public virtual ICollection<Personne> Personnes { get; set; }
    }
}