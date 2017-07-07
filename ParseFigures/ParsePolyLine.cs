using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class ParsePolyLine : IParse
    {
        public override long ParseFigure(DxfReader reader)
        {
            Console.WriteLine("Parsing POLYLINE...");
            bool error;
            DxfReader tempReader = DxfReader.Clone(reader);
/*            Dictionary<string, double> polyLineDictionary = new Dictionary<string, double>()
            {
                { "90", 0 }     // points' number
//                { "10", 0 },     // points' x
//                { "20", 0 },     // point' y
            };
            // создать указанное "90" точек и таскать перо между ними без подъема
*/
            
            for(;;)
            {

            }
            return tempReader.Counter - 2;
        }
    }
}
