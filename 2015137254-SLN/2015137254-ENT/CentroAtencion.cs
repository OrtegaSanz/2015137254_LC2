using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT
{
    public class CentroAtencion
    {
        public int CentroAtencionId { get; set; }
        private Direccion _Direccion;
        public CentroAtencion()
        {
            _Direccion = new Direccion();
        }
    }
}
