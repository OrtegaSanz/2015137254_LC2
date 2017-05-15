using _2015137254_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_PER.EntityTypeConfiguration
{
    public class UbigeoConfiguration : EntityTypeConfiguration<Ubigeo>
    {
        public UbigeoConfiguration()
        {
            ToTable("Ubigeos");
            HasKey(c => c.UbigeoId);
        }
    }
}
