using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    public class ParseArc : IParse
    {
        public override long ParseFigure(DxfReader reader)
        {
            Console.WriteLine("Parsing ARC...");
            bool error;
            DxfReader tempReader = DxfReader.Clone(reader);
            Dictionary<string, double> arcDictionary = new Dictionary<string, double>()
            {
                { "10", 0 },     // xCenter
                { "20", 0 },     // yCenter
                { "40", 0 },     // radius
                { "50", 0 },     // angleStart
                { "51", 0 }      // angleStop
            };

            arcDictionary = Figure.Parser(tempReader, arcDictionary, out error);

            Arc.Create(arcDictionary["10"], arcDictionary["20"],
                        arcDictionary["40"], arcDictionary["50"],
                        arcDictionary["51"], error);

            return tempReader.Counter - 2; // тут seek лучше прикрутить
        }
    }
}
