using _2015137254_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_PER.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly _2015137254DbContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IAdministradorEquipoRepository AdministradorEquipoes { get; private set; }

        public IAdministradorLineaRepository AdministradorLineaes { get; private set; }

        public ICentroAtencionRepository CentroAtenciones { get;private set; }
        public IContratoRepository Contratoes { get; private set; }

        public IClienteRepository Clientes { get;private set; }

        public IDepartamentoRepository Departamentoes { get; private set; }

        public IDireccionRepository Direcciones { get;private set; }

        public IDistritoRepository Distritoes { get;private set; }

        public IEquipoCelularRepository EquipoCelulares { get;private set; }

        public IEstadoEvaluacionRepository EstadoEvaluaciones { get;private set; }

        public IEvaluacionRepository Evaluaciones { get;private set; }

        public ILineaTelefonicaRepository LineaTelefonicaes { get;private set; }

        public IPlanRepository Planes { get;private set; }

        public IProvinciaRepository Provinciaes { get;private set; }

        public ITipoEvaluacionRepository TipoEvaluaciones { get;private set; }

        public ITipoLineaRepository TipoLineaes { get;private set; }

        public ITipoPagoRepository TipoPagoes { get;private set; }

        public ITipoPlanRepository TipoPlanes { get;private set; }

        public ITipoTrabajadorRepository TipoTrabajadores { get;private set; }

        public ITrabajadorRepository Trabajadores { get;private set; }

        public IUbigeoRepository Ubigeoes { get;private set; }

        public IVentaRepository Ventaes { get;private set; }

        public UnityOfWork()
        {

        }
        public UnityOfWork(_2015137254DbContext context)
        {
            _Context = context;

            AdministradorEquipoes = new AdministradorEquipoRepository(_Context);
            AdministradorLineaes = new AdministradorLineaRepository(_Context);
            CentroAtenciones = new CentroAtencionRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Contratoes = new ContratoRepository(_Context);
            Departamentoes = new DepartamentoRepository(_Context);
            Direcciones = new DireccionRepository(_Context);
            Distritoes = new DistritoRepository(_Context);
            EquipoCelulares = new EquipoCelularRepository(_Context);
            EstadoEvaluaciones = new EstadoEvaluacionRepository(_Context);
            Evaluaciones = new EvaluacionRepository(_Context);
            LineaTelefonicaes = new LineaTelefonicaRepository(_Context);
            Planes = new PlanRepository(_Context);
            Provinciaes = new ProvinciaRepository(_Context);
            TipoEvaluaciones = new TipoEvaluacionRepository(_Context);
            TipoLineaes = new TipoLineaRepository(_Context);
            TipoPagoes = new TipoPagoRepository(_Context);
            TipoPlanes = new TipoPlanRepository(_Context);
            TipoTrabajadores = new TipoTrabajadorRepository(_Context);
            Trabajadores = new TrabajadorRepository(_Context);
            Ubigeoes = new UbigeoRepository(_Context);
            Ventaes = new VentaRepository(_Context);
        }
        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if(_Instance == null)
                    {
                        _Instance = new UnityOfWork();
                    }
                }
                return _Instance;
            }
        }
        void IDisposable.Dispose()
        {
            _Context.Dispose();
        }

        int IUnityOfWork.SaveChanges()
        {
            return _Context.SaveChanges();
        }
        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
