using _2015137254_ENT.Entities;
using _2015137254_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_PER.Repository
{
    public class DireccionRepository : Repository<Direccion>, IDireccionRepository
    {
        public DireccionRepository(_2015137254DbContext context) : base(context)
		{
        }
    }
}
