using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAdministradorEquipoRepository AdministradorEquipoes { get; }
        IAdministradorLineaRepository AdministradorLineaes { get; }
        ICentroAtencionRepository CentroAtenciones { get; }
        IContratoRepository Contratoes { get; }
        IClienteRepository Clientes { get; }
        IDepartamentoRepository Departamentoes { get; }
        IDireccionRepository Direcciones { get; }
        IDistritoRepository Distritoes { get; }
        IEquipoCelularRepository EquipoCelulares { get; }
        IEstadoEvaluacionRepository EstadoEvaluaciones { get; }
        IEvaluacionRepository Evaluaciones { get; }
        ILineaTelefonicaRepository LineaTelefonicaes { get; }
        IPlanRepository Planes { get; }
        IProvinciaRepository Provinciaes { get; }
        ITipoEvaluacionRepository TipoEvaluaciones { get; }
        ITipoLineaRepository TipoLineaes { get; }
        ITipoPagoRepository TipoPagoes { get; }
        ITipoPlanRepository TipoPlanes { get; }
        ITipoTrabajadorRepository TipoTrabajadores { get; }
        ITrabajadorRepository Trabajadores { get; }
        IUbigeoRepository Ubigeoes { get; }
        IVentaRepository Ventaes { get; }

        int SaveChanges();
        void StateModified(object entity);
    }
}
