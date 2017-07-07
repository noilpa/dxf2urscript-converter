using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dxf2UrScript
{
    public class DxfReader
    {
        
        private static Dictionary<string, IParse> parseDictionary;

        public StreamReader streamReader { get; private set; }
        public string Code  { get; private set; } // string1
        public string Value { get; private set; } // string2
        public long Counter { get; private set; } // номер строки следующей строки, шаг 2

        private DxfReader(StreamReader streamReader)
        {
            this.Code = "";
            this.Value = "";
            this.Counter = 0;
            this.streamReader = streamReader;
        }

        private DxfReader(DxfReader reader)
        {
            this.Code = reader.Code;
            this.Value = reader.Value;
            this.Counter = reader.Counter;
            this.streamReader = reader.streamReader;
        }

        public static DxfReader Create (string path)
        {
            try
            {
                StreamReader streamReader = new StreamReader(path);
                initParseDictionary();
                return new DxfReader(streamReader);
            }
            catch
            {
                Console.WriteLine("Такой файл не существует");
                return null;
            }
            
        }

        public static DxfReader Clone (DxfReader reader)
        {
            return new DxfReader(reader);
        }

        private static void initParseDictionary()
        {
            parseDictionary = new Dictionary<string, IParse>();
            parseDictionary.Add("LINE", new ParseLine());
//            parseDictionary.Add("LWPOLYLINE", new ParsePolyLine());   // не понятны значимые коды
            parseDictionary.Add("ARC", new ParseArc());
            parseDictionary.Add("CIRCLE", new ParseCircle());
        }
        
        /// <summary>
        /// Calling IParse implemintation to create a figure
        /// </summary>
        /// <param name="parseType"></param>
        /// <param name="readerPosition"></param>
        public static long CallParser(IParse parseType, DxfReader reader)
        {
            return parseType.ParseFigure(reader);
        }

        /// <summary>
        /// Go to the Entity section
        /// </summary>
        private void InEntities() // private
        {
            do
            {
                GetLineCouple();
//                Console.WriteLine(Code);
//                Console.WriteLine(Value);
            } while (
                        !(string.IsNullOrEmpty(this.Value) && string.IsNullOrEmpty(this.Code)) &&
                        !(this.Value.Equals("ENTITIES") && this.Code.Equals("2"))
                    );
        }

        /*
        public void PrintAllFile()
        {
            string str = "";
            while((str = this.streamReader.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
            streamReader.Close();
        }
        */

        /// <summary>
        /// Get code line and value line from dxf file
        /// </summary>
        public void GetLineCouple()   //private??
        {
            
            if (!string.IsNullOrEmpty(this.Code = this.streamReader.ReadLine()))
            {
                this.Code = this.Code.Trim();
            }
            
            if (!string.IsNullOrEmpty(this.Value = this.streamReader.ReadLine()))
            {
                this.Value = this.Value.Trim();
            }

            this.Counter += 2;
        }

        public void GoToLine(long number)
        {

            this.streamReader.DiscardBufferedData();
            this.streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            this.streamReader.BaseStream.Position = 0;
            this.Counter = 0;
            for (int i=0; i<number; i++)
            {
                this.streamReader.ReadLine();
                this.Counter++;
            }
        }

        public void ParseFigures()
        {
            InEntities();

            do
            {
                GetLineCouple();
                if (!string.IsNullOrEmpty(this.Value) || !string.IsNullOrEmpty(this.Code))
                {
                    if (parseDictionary.ContainsKey(this.Value))
                    {
                        long temp = CallParser(parseDictionary[this.Value], this);
                        this.GoToLine(temp);
                    }
                }
            } while (
                        !(string.IsNullOrEmpty(this.Value) && string.IsNullOrEmpty(this.Code)) &&
                        !(this.Value.Equals("ENDSEC") && this.Code.Equals("0")) 
                    );

            streamReader.Close();
        }

    }
}
