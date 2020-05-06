using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AfpaTinderMvc.Models
{
    public class Ville
    {
        public Ville()
        {
            Personnes = new HashSet<Personne>();
        }

        [Key]
        [Column("idVille")]
        public int IdVille { get; set; }

        [StringLength(50)]
        [Required]
        [Column("nom")]
        public string Nom { get; set; }

        [StringLength(5)]
        [Required]
        [Column("codePostal")]
        public string CodePostal { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public virtual ICollection<Personne> Personnes { get; set; }
    }
}