﻿using _2015137254_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_PER.EntityTypeConfiguration
{
    public class TipoEvaluacionConfiguration : EntityTypeConfiguration<TipoEvaluacion>
    {
        public TipoEvaluacionConfiguration()
        {
            ToTable("TipoEvaluaciones");
            HasKey(c => c.TipoEvaluacionId);
        }
    }
}