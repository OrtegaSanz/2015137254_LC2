using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT
{
    public class Direccion
    {
        public int DireccionId { get; set; }
        private Ubigeo _Ubigeo;
        public Departamento departamento { get; set; }
        public Distrito distrito { get; set; }
        public Provincia provincia { get; set; }
        public Direccion()
        {
            _Ubigeo = new Ubigeo(departamento,provincia,distrito);
        }
    }
}
