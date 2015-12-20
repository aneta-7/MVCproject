using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Samoloty.Models
{
    public partial class Przelot
    { 
    public int ID { get; set; }
    public string PunktStartowty { get; set; }
    public DateTime Data1 { get; set; }
    public string Czas1 { get; set; }
    public string PunktKoncowy { get; set; }
    public DateTime Data2 { get; set; }
    public string Czas2 { get; set; }

}

public class PrzelotDBContext : DbContext
{

        public DbSet<Przelot> Przeloty { get; set; }
    }
}