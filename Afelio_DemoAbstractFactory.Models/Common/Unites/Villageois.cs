using Afelio_DemoAbstractFactory.Models.Common.Structrures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afelio_DemoAbstractFactory.Models.Common.Unites
{
    public abstract class Villageois : PNJ
    {
        public Villageois(int pv) : base(pv)
        {

        }

        public abstract Maison CreeMaison();
        public abstract Moulin CreeMoulin();
        public abstract Caserne CreeCaserne();
        public abstract Forum CreeForum();
    }
}
