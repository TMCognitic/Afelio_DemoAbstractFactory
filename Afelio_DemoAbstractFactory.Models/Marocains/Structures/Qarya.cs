using Afelio_DemoAbstractFactory.Models.Common.Structrures;
using Afelio_DemoAbstractFactory.Models.Common.Unites;
using Afelio_DemoAbstractFactory.Models.Marocains.Unites;

namespace Afelio_DemoAbstractFactory.Models.Marocains.Structures
{
    public class Qarya : Forum
    {
        public override Villageois CreeVillageois()
        {
            return new Qarawiun();
        }
    }
}
