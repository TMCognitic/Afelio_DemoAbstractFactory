using Afelio_DemoAbstractFactory.Models.Common.Structrures;
using Afelio_DemoAbstractFactory.Models.Common.Unites;
using Afelio_DemoAbstractFactory.Models.Francais.Unites;

namespace Afelio_DemoAbstractFactory.Models.Francais.Structures
{
    public class ForumFrancais : Forum
    {
        public override Villageois CreeVillageois()
        {
            return new VillageoisFrancais();
        }
    }
}
