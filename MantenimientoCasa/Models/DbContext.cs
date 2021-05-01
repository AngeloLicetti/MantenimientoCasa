using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MantenimientoCasa.Models
{
    public class MantenimientoCasaDbContext : DbContext
    {
        public MantenimientoCasaDbContext()
        : base("dbSmarter")
        {

        }

        public DbSet<Casa> Casas { get; set; }
    }
}