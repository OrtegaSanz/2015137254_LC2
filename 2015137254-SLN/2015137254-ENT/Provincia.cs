using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }
        private Distrito _Distrito;
        public Provincia()
        {
            _Distrito = new Distrito();
        }
    }
}
