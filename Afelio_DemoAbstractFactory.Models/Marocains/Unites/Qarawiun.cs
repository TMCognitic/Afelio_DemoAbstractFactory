using Afelio_DemoAbstractFactory.Models.Common.Structrures;
using Afelio_DemoAbstractFactory.Models.Common.Unites;
using Afelio_DemoAbstractFactory.Models.Marocains.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afelio_DemoAbstractFactory.Models.Marocains.Unites
{
    public class Qarawiun : Villageois
    {
        public Qarawiun() : base(5)
        {

        }

        public override Caserne CreeCaserne()
        {
            return new CaserneMarocaine();
        }

        public override Forum CreeForum()
        {
            return new Qarya();
        }

        public override Maison CreeMaison()
        {
            return new Dar();
        }

        public override Moulin CreeMoulin()
        {
            return new Muthana();
        }
    }
}
