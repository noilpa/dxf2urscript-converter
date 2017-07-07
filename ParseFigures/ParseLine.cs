
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class ParseLine : IParse
    {
        public override long ParseFigure(DxfReader reader)
        {
            bool error = false;
            Console.WriteLine("Parsing LINE...");
            DxfReader tempReader = DxfReader.Clone(reader);
            Dictionary<string, double> lineDictionary = new Dictionary<string, double>()
            {
                { "10", 0 },     // x1
                { "11", 0 },     // x2
                { "20", 0 },     // y1
                { "21", 0 }      // y2
            };
            
            lineDictionary = Figure.Parser(tempReader, lineDictionary, out error);

            Line.Create(lineDictionary["10"], lineDictionary["20"],
                        lineDictionary["11"], lineDictionary["21"], error);

            return tempReader.Counter - 2; // тут seek лучше прикрутить
        }

    }
}
