using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class ParseAgent
    {
        public static void CallParser(IParse parseType, long readerPosition)
        {
            parseType.ParseFigure(readerPosition);
        }
    }
}
