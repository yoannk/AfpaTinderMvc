﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AfpaTinderMvc.Models
{
    [Table("Personne")]
    public class Personne
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Nom { get; set; }

        [StringLength(100)]
        [Required]
        public string Prenom { get; set; }

        [StringLength(100)]
        [Required]
        public string Email { get; set; }

        [StringLength(100)]
        [Required]
        public string Login { get; set; }

        [StringLength(100)]
        [Required]
        public string Password { get; set; }

        [StringLength(100)]
        [Required]
        public string Telephone { get; set; }

        [Required]
        public bool Statut { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }
    }
}