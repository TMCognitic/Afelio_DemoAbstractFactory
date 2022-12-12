using Afelio_DemoAbstractFactory.Models.Common.Structrures;
using Afelio_DemoAbstractFactory.Models.Common.Unites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afelio_DemoAbstractFactory.Models.Marocains.Structures
{
    public class CaserneMarocaine : Caserne
    {
        public override Soldat CreeSoldat()
        {
            throw new NotImplementedException();
        }
    }
}
