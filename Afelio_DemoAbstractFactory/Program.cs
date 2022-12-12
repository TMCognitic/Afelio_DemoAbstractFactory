using Afelio_DemoAbstractFactory.Models.Common.Structrures;
using Afelio_DemoAbstractFactory.Models.Common.Unites;
using Afelio_DemoAbstractFactory.Models.Francais.Structures;

namespace Afelio_DemoAbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forum forum = new ForumFrancais();

            Villageois villageois = forum.CreeVillageois();
            Console.WriteLine(villageois);
            Console.WriteLine(villageois.CreeMoulin());
            Console.WriteLine(villageois.CreeMaison());
            Console.WriteLine(villageois.CreeCaserne());
            Console.WriteLine(villageois.CreeForum());
        }
    }
}