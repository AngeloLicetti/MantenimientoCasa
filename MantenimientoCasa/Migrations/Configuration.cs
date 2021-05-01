namespace MantenimientoCasa.Migrations
{
    using MantenimientoCasa.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MantenimientoCasa.Models.MantenimientoCasaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MantenimientoCasa.Models.MantenimientoCasaDbContext";
        }

        protected override void Seed(MantenimientoCasa.Models.MantenimientoCasaDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Casas.AddOrUpdate(x => x.id,
            new Casa() { id = 1, numPuertas = 10, numVentanas = 14, anoConstruccion = 1985, direccion = "Parque Del Carmen 190, Pueblo Libre", metrosArea = 95 } ,
            new Casa() { id = 2, numPuertas = 8, numVentanas = 11, anoConstruccion = 2001, direccion = "Av. Brasil 1485, Jesús María", metrosArea = 93 } ,
            new Casa() { id = 3, numPuertas = 6, numVentanas = 9, anoConstruccion = 1994, direccion = "Av. Benvaides 3533, Surco", metrosArea = 113.5 }
            );
        }
    }
}
