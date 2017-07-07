using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    public abstract class IParse
    {
        public abstract long ParseFigure(DxfReader reader);
    }
}
