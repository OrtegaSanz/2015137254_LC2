using _2015137254_ENT.Entities;
using _2015137254_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_PER.Repository
{
    public class DepartamentoRepository : Repository<Departamento>, IDepartamentoRepository
    {
        private readonly _2015137254DbContext _Context;

        private DepartamentoRepository()
        {

        }

        public DepartamentoRepository(_2015137254DbContext context)
        {
            _Context = context;
        }
    }
}
