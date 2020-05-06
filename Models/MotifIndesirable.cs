using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AfpaTinderMvc.Models
{
    public class MotifIndesirable
    {
        [Key]
        [Column("idMotifIndesirable")]
        public int IdMotifIndesirable { get; set; }

        [StringLength(50)]
        [Required]
        [Column("nom")]
        public string Nom { get; set; }
    }
}