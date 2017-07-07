using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class ParseCircle : IParse
    {
        public override long ParseFigure(DxfReader reader)
        {
            Console.WriteLine("Parsing CIRCLE...");
            bool error;
            DxfReader tempReader = DxfReader.Clone(reader);
            Dictionary<string, double> circleDictionary = new Dictionary<string, double>()
            {
                { "10", 0 },     // xCenter
                { "20", 0 },     // yCenter
                { "40", 0 }      // radius
            };

            circleDictionary = Figure.Parser(tempReader, circleDictionary, out error);

            Circle.Create(circleDictionary["10"], circleDictionary["20"],
                          circleDictionary["40"], error);

            return tempReader.Counter - 2; // тут seek лучше прикрутить 
        }
    }
}
