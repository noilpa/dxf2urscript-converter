using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class ParsePoint : IParse
    {
        public override long ParseFigure(DxfReader reader)
        {
            bool error = false;
            Console.WriteLine("Parsing POINT...");
            DxfReader tempReader = DxfReader.Clone(reader);
            Dictionary<string, double> pointDictionary = new Dictionary<string, double>()
            {
                { "10", 0 },     // x1
                { "20", 0 },     // y1
            };

            pointDictionary = Figure.Parser(tempReader, pointDictionary, out error);

            Point.Create(pointDictionary["10"], pointDictionary["20"], error);

            return tempReader.Counter - 2; // тут seek лучше прикрутить
        }
    }
}
