using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    class Converter
    {
        // получить List allFigures
        // обработать 
        // записать в файл

//        private static Dictionary<string, IConvert> convertDictionary;

        public static void Convert(List<Figure> allFigures, string outputPath)
        {

            string path = outputPath;
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8); 

            foreach (Figure figure in allFigures)
            {
                if (!figure.Error)
                {
                    string figureName = figure.GetType().Name;
                    Console.WriteLine("Converting {0}...", figureName);
                    switch (figureName)
                    {
                        case "Line":
                            sw.WriteLine("\"DrawLine({0}, {1}, {2}, {3})\"", ((Line)figure).X1,
                                         ((Line)figure).Y1, ((Line)figure).X2, ((Line)figure).Y2);
                            break;
                        case "Circle":
                            sw.WriteLine("\"DrawCircle({0}, {1}, {2})\"", ((Circle)figure).X1,
                                         ((Circle)figure).Y1, ((Circle)figure).Radius);
                            break;
                        case "Arc":
                            sw.WriteLine("\"DrawArc({0}, {1}, {2}, {3}, {4}, {5})\"", 
                                         ((Arc)figure).XStart, ((Arc)figure).YStart,
                                         ((Arc)figure).XStop, ((Arc)figure).YStop,
                                         ((Arc)figure).XVia, ((Arc)figure).YVia);
                            break;
                        case "Point":
                            sw.WriteLine("\"DrawPoint({0}, {1})\"", ((Point)figure).X1, ((Point)figure).Y1);
                            break;
                        default:
                            Console.WriteLine("Unsupported figure type: {0}", figureName);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Corrupted figure {0}", figure.GetType().Name);
                }
            }

            sw.Close();
        }


    }
}
