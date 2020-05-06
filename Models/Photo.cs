using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AfpaTinderMvc.Models
{
    public class Photo
    {
        [Key]
        [Column("idPhoto")]
        public int IdPhoto { get; set; }

        [StringLength(50)]
        [Required]
        [Column("nom")]
        public string Nom { get; set; }

        [StringLength(50)]
        [Required]
        [Column("url")]
        public string Url { get; set; }

        public virtual TaillePhoto TaillePhoto { get; set; }
        public virtual Personne Personne{ get; set; }

    }
}