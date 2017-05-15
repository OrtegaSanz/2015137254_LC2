using _2015137254_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_PER
{
    public class _2015137254DbContext :DbContext
    {
        public DbSet<AdministradorEquipo> AdministradorEquipos { get; set; }
        public DbSet<AdministradorLinea> AdministradorLinea { get; set; }
        public DbSet<CentroAtencion> CentrosAtencion { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contrato> Contactos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<EquipoCelular> EquiposCelular { get; set; }
        public DbSet<EstadoEvaluacion> EstadoEvaluaciones { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<LineaTelefonica> LineasTelefonicas { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<TipoEvaluacion> TipoEvaluaciones { get; set; }
        public DbSet<TipoLinea> TipoLineas { get; set; }
        public DbSet<TipoPago> TipoPagos { get; set; }
        public DbSet<TipoPlan> TipoPlanes { get; set; }
        public DbSet<TipoTrabajador> TipoTrabajadores { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Ubigeo> Ubigeos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

    }
}
