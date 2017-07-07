using System;
using System.Collections.Generic;

namespace Dxf2UrScript
{
    public abstract class Figure
    {

        private static List<Figure> allFigures = new List<Figure>();

        public bool Error { get; protected set; }  // фигура битая? - да  -> true
                                                   //               - нет -> false
        public static List<Figure> GetAllFigures()
        {
            List<Figure> temp = new List<Figure>(allFigures);
            return temp;
        }
        
        public static void AddToList(Figure figure)
        {
            allFigures.Add(figure);
        }

        public static Dictionary<string, double> Parser(DxfReader tempReader,
                                                        Dictionary<string, double> figureDictionary,
                                                        out bool error)
        {
            error = false;
            do
            {
                tempReader.GetLineCouple();
                if (!string.IsNullOrEmpty(tempReader.Value) || !string.IsNullOrEmpty(tempReader.Code))
                {
                    if (figureDictionary.ContainsKey(tempReader.Code))
                    {
                        try
                        {
                            figureDictionary[tempReader.Code] = Double.Parse(tempReader.Value, System.Globalization.CultureInfo.InvariantCulture); // добавить форматирование
                        }
                        catch (Exception)
                        {
                            error = true;
                        }
                    }
                }
            } while (!(string.IsNullOrEmpty(tempReader.Value) && string.IsNullOrEmpty(tempReader.Code)) &&
                     !tempReader.Code.Equals("0"));

            return figureDictionary;
        }
    }
}