using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        private Provincia _Provincia;
        public Departamento()
        {
            _Provincia = new Provincia();
        }
    }
}
