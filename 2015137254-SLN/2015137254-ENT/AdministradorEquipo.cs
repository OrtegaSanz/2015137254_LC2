using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT
{
    public class AdministradorEquipo
    {
        public int AdministradorEquipoId { get; set; }
        private EquipoCelular _EquipoCelular;
        public AdministradorEquipo()
        {
            _EquipoCelular = new EquipoCelular();
        }
    }
}
