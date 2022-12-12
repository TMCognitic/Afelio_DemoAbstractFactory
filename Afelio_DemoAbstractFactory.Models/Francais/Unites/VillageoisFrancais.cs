using Afelio_DemoAbstractFactory.Models.Common.Structrures;
using Afelio_DemoAbstractFactory.Models.Common.Unites;
using Afelio_DemoAbstractFactory.Models.Francais.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afelio_DemoAbstractFactory.Models.Francais.Unites
{
    public class VillageoisFrancais : Villageois
    {
        public VillageoisFrancais() : base(3) 
        {

        }

        public override Caserne CreeCaserne()
        {
            return new CaserneFrancaise();
        }

        public override Forum CreeForum()
        {
            return new ForumFrancais();
        }

        public override Maison CreeMaison()
        {
            return new MaisonFrancaise();
        }

        public override Moulin CreeMoulin()
        {
            return new MoulinFrancais();
        }
    }
}
