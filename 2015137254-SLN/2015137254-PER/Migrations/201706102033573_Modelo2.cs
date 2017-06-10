namespace _2015137254_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modelo2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdministradorEquipoes", "Descripcion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdministradorEquipoes", "Descripcion");
        }
    }
}
