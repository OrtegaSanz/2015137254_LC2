using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        private EquipoCelular _EquipoCelular;
        private EstadoEvaluacion _EstadoEvaluacion;
        private TipoEvaluacion _TipoEvaluacion;
        private Cliente _Cliente;
        private Plan _Plan;
        private LineaTelefonica _LineaTelefonica;
        public CentroAtencion _CentroAtencion { get; set; }
        public Trabajador _Trabajador { get; set; }
        public Evaluacion(Cliente cliente,Plan plan,LineaTelefonica lineaTelefonica,CentroAtencion centroAtencion,Trabajador trabajador)
        {
            _EquipoCelular = new EquipoCelular();
            _EstadoEvaluacion = new EstadoEvaluacion();
            _TipoEvaluacion = new TipoEvaluacion();
            _Cliente = cliente;
            _Plan = plan;
            _LineaTelefonica = lineaTelefonica;
            _CentroAtencion = centroAtencion;
            _Trabajador = trabajador;
        }
    }
}
