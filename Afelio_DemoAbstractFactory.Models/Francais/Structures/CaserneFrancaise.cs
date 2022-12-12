using Afelio_DemoAbstractFactory.Models.Common.Structrures;
using Afelio_DemoAbstractFactory.Models.Common.Unites;
using Afelio_DemoAbstractFactory.Models.Francais.Unites;

namespace Afelio_DemoAbstractFactory.Models.Francais.Structures
{
    public class CaserneFrancaise : Caserne
    {
        public override Soldat CreeSoldat()
        {
            return new SoldatFrancais();
        }
    }
}
