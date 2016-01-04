using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Samoloty.Models
{
    public partial class Samolot
    {
        [Display(Name = "ID Samolotu")]
        [Required]
        public int ID { get; set; }
        [Display(Name = "Nazwa ")]
        [Required]
        [MaxLength(20)]
        public string Nazwa { get; set; }
        [Display(Name = "Typ")]
        [Required]
        [MaxLength(20)]
        public string Typ { get; set; }
        [Display(Name = "Przelot")]
        public ICollection<Przelot> Przelot_id { get; set; }

    }

    public class SamolotDBContext : DbContext
    {
       
        public DbSet<Samolot> Samolots { get; set; }

        public System.Data.Entity.DbSet<Samoloty.Models.Przelot> Przelots { get; set; }
    }
}