namespace MantenimientoCasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Casas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numPuertas = c.Int(nullable: false),
                        numVentanas = c.Int(nullable: false),
                        anoConstruccion = c.Int(nullable: false),
                        direccion = c.String(),
                        metrosArea = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Casas");
        }
    }
}
