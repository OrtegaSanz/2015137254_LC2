using _2015137254_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_PER.EntityTypeConfiguration
{
    public class TrabajadorConfiguration : EntityTypeConfiguration<Trabajador>
    {
        public TrabajadorConfiguration()
        {
            ToTable("Trabajadores");
            HasKey(c => c.TrabajadorId);
        }
    }
}
