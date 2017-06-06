using _2015137254_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_PER.EntityTypeConfiguration
{
    public class PlanConfiguration : EntityTypeConfiguration<Plan>
    {
        public PlanConfiguration()
        {
            ToTable("Planes");
            HasKey(c => c.PlanId);
        }
    }
}
