using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afelio_DemoAbstractFactory.Models.Common.Unites
{
    public abstract class PNJ
    {
        public int PV { get; init; }

        public PNJ(int pv)
        {
            PV = pv;
        }
    }
}
