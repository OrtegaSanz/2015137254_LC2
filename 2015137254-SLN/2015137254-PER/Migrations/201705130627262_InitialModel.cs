namespace _2015137254_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdministradorEquipoes",
                c => new
                    {
                        AdministradorEquipoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AdministradorEquipoId);
            
            CreateTable(
                "dbo.AdministradorLineas",
                c => new
                    {
                        AdministradorLineaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AdministradorLineaId);
            
            CreateTable(
                "dbo.CentroAtencions",
                c => new
                    {
                        CentroAtencionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CentroAtencionId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Contratoes",
                c => new
                    {
                        ContratoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ContratoId);
            
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        DireccionId = c.Int(nullable: false, identity: true),
                        departamento_DepartamentoId = c.Int(),
                        distrito_DistritoId = c.Int(),
                        provincia_ProvinciaId = c.Int(),
                    })
                .PrimaryKey(t => t.DireccionId)
                .ForeignKey("dbo.Departamentoes", t => t.departamento_DepartamentoId)
                .ForeignKey("dbo.Distritoes", t => t.distrito_DistritoId)
                .ForeignKey("dbo.Provincias", t => t.provincia_ProvinciaId)
                .Index(t => t.departamento_DepartamentoId)
                .Index(t => t.distrito_DistritoId)
                .Index(t => t.provincia_ProvinciaId);
            
            CreateTable(
                "dbo.Distritoes",
                c => new
                    {
                        DistritoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DistritoId);
            
            CreateTable(
                "dbo.Provincias",
                c => new
                    {
                        ProvinciaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.EquipoCelulars",
                c => new
                    {
                        EquipoCelularId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EquipoCelularId);
            
            CreateTable(
                "dbo.EstadoEvaluacions",
                c => new
                    {
                        EstadoEvaluacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EstadoEvaluacionId);
            
            CreateTable(
                "dbo.Evaluacions",
                c => new
                    {
                        EvaluacionId = c.Int(nullable: false, identity: true),
                        _CentroAtencion_CentroAtencionId = c.Int(),
                        _Trabajador_TrabajadorId = c.Int(),
                    })
                .PrimaryKey(t => t.EvaluacionId)
                .ForeignKey("dbo.CentroAtencions", t => t._CentroAtencion_CentroAtencionId)
                .ForeignKey("dbo.Trabajadors", t => t._Trabajador_TrabajadorId)
                .Index(t => t._CentroAtencion_CentroAtencionId)
                .Index(t => t._Trabajador_TrabajadorId);
            
            CreateTable(
                "dbo.Trabajadors",
                c => new
                    {
                        TrabajadorId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TrabajadorId);
            
            CreateTable(
                "dbo.LineaTelefonicas",
                c => new
                    {
                        LineaTelefonicaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.LineaTelefonicaId);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        PlanId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PlanId);
            
            CreateTable(
                "dbo.TipoEvaluacions",
                c => new
                    {
                        TipoEvaluacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoEvaluacionId);
            
            CreateTable(
                "dbo.TipoLineas",
                c => new
                    {
                        TipoLineaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoLineaId);
            
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        TipoPagoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoPagoId);
            
            CreateTable(
                "dbo.TipoPlans",
                c => new
                    {
                        TipoPlanId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoPlanId);
            
            CreateTable(
                "dbo.TipoTrabajadors",
                c => new
                    {
                        TipoTrabajadorId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoTrabajadorId);
            
            CreateTable(
                "dbo.Ubigeos",
                c => new
                    {
                        UbigeoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.UbigeoId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        _CentroAtencion_CentroAtencionId = c.Int(),
                        _Plan_PlanId = c.Int(),
                        _Trabajador_TrabajadorId = c.Int(),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.CentroAtencions", t => t._CentroAtencion_CentroAtencionId)
                .ForeignKey("dbo.Plans", t => t._Plan_PlanId)
                .ForeignKey("dbo.Trabajadors", t => t._Trabajador_TrabajadorId)
                .Index(t => t._CentroAtencion_CentroAtencionId)
                .Index(t => t._Plan_PlanId)
                .Index(t => t._Trabajador_TrabajadorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "_Trabajador_TrabajadorId", "dbo.Trabajadors");
            DropForeignKey("dbo.Ventas", "_Plan_PlanId", "dbo.Plans");
            DropForeignKey("dbo.Ventas", "_CentroAtencion_CentroAtencionId", "dbo.CentroAtencions");
            DropForeignKey("dbo.Evaluacions", "_Trabajador_TrabajadorId", "dbo.Trabajadors");
            DropForeignKey("dbo.Evaluacions", "_CentroAtencion_CentroAtencionId", "dbo.CentroAtencions");
            DropForeignKey("dbo.Direccions", "provincia_ProvinciaId", "dbo.Provincias");
            DropForeignKey("dbo.Direccions", "distrito_DistritoId", "dbo.Distritoes");
            DropForeignKey("dbo.Direccions", "departamento_DepartamentoId", "dbo.Departamentoes");
            DropIndex("dbo.Ventas", new[] { "_Trabajador_TrabajadorId" });
            DropIndex("dbo.Ventas", new[] { "_Plan_PlanId" });
            DropIndex("dbo.Ventas", new[] { "_CentroAtencion_CentroAtencionId" });
            DropIndex("dbo.Evaluacions", new[] { "_Trabajador_TrabajadorId" });
            DropIndex("dbo.Evaluacions", new[] { "_CentroAtencion_CentroAtencionId" });
            DropIndex("dbo.Direccions", new[] { "provincia_ProvinciaId" });
            DropIndex("dbo.Direccions", new[] { "distrito_DistritoId" });
            DropIndex("dbo.Direccions", new[] { "departamento_DepartamentoId" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Ubigeos");
            DropTable("dbo.TipoTrabajadors");
            DropTable("dbo.TipoPlans");
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.TipoLineas");
            DropTable("dbo.TipoEvaluacions");
            DropTable("dbo.Plans");
            DropTable("dbo.LineaTelefonicas");
            DropTable("dbo.Trabajadors");
            DropTable("dbo.Evaluacions");
            DropTable("dbo.EstadoEvaluacions");
            DropTable("dbo.EquipoCelulars");
            DropTable("dbo.Provincias");
            DropTable("dbo.Distritoes");
            DropTable("dbo.Direccions");
            DropTable("dbo.Departamentoes");
            DropTable("dbo.Contratoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.CentroAtencions");
            DropTable("dbo.AdministradorLineas");
            DropTable("dbo.AdministradorEquipoes");
        }
    }
}
