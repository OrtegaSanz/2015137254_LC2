using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT
{
    public class Venta
    {
        public int VentaId { get; set; }
        private Contrato _Contrato;
        private TipoPago _TipoPago;
        private Cliente _Cliente;
        private Evaluacion _Evaluacion;
        private LineaTelefonica _LineaTelefonica;
        public CentroAtencion _CentroAtencion { get; set; }
        //----------------------------------------------------------
        public Plan _Plan { get; set; }
        public Trabajador _Trabajador { get; set; }
        public Venta(Cliente cliente, CentroAtencion centroAtencion)
        {
            _Contrato = new Contrato();
            _TipoPago = new TipoPago();
            _LineaTelefonica = new LineaTelefonica();
            _Evaluacion = new Evaluacion(_Cliente,_Plan,_LineaTelefonica,_CentroAtencion,_Trabajador);
            _Cliente = cliente;
            _CentroAtencion = centroAtencion;
        }
    }
}
