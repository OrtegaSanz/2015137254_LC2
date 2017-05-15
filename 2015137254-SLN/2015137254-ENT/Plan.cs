using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT
{
    public class Plan
    {
        public int PlanId { get; set; }
        private TipoPlan _TipoPlan;
        public Plan()
        {
            _TipoPlan = new TipoPlan();
        }
    }
}
