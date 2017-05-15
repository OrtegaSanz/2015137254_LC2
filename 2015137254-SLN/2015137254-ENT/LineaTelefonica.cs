using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT
{
    public class LineaTelefonica
    {
        public int LineaTelefonicaId { get; set; }
        private TipoLinea _TipoLinea;
        public LineaTelefonica()
        {
            _TipoLinea = new TipoLinea();
        }
    }
}
