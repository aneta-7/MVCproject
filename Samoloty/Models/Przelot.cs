﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Samoloty.Models
{
    public partial class Przelot
    {

        [Key]
        [Display(Name = "ID przelotu")]
        public int ID { get; set; }
        [Display(Name = "Miejsce wylotu")]
        [MaxLength(60)]
        [Required]
        public string PunktStartowty { get; set; }
        [Display(Name = "Data wylotu")]
        [Required]
        public DateTime Data1 { get; set; }
        [Display(Name = "Godzina wylotu")]
        [Required]
        public string Czas1 { get; set; }
        [Display(Name = "Miejsce lądowania")]
        [MaxLength(60)]
        [Required]
        public string PunktKoncowy { get; set; }
        [Display(Name = "Data lądowania")]
        [Required]
        public DateTime Data2 { get; set; }
        [Display(Name = "Godzina lądowania")]
        [Required]
        public string Czas2 { get; set; }
        [Display(Name = "Samolot")]
        [Required]
        public ICollection<Samolot> Samolot_id { get;  set;}
}

public class PrzelotDBContext : DbContext
{
        public DbSet<Przelot> Przeloty { get; set; }

        public System.Data.Entity.DbSet<Samoloty.Models.Samolot> Samoloty { get; set; }
    }
}