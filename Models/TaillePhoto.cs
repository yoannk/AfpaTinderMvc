using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AfpaTinderMvc.Models
{
    public class TaillePhoto
    {
        [Key]
        [Column("idTaillePhoto")]
        public int IdTaillePhoto { get; set; }

        [StringLength(50)]
        [Required]
        [Column("nom")]
        public string Nom { get; set; }

        [Required]
        public int Largeur { get; set; }

        [Required]
        public int Hauteur { get; set; }
    }
}