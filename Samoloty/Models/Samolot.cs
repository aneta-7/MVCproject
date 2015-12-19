using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Samoloty.Models
{
    public partial class Samolot
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Typ { get; set; }
     
    }

    public class SamolotDBContext : DbContext
    {
        public override int SaveChanges() { return 0; }
        public DbSet<Samolot> Samolots { get; set; }

        public System.Data.Entity.DbSet<Samoloty.Models.Przelot> Przelots { get; set; }
    }
}