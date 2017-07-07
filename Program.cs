using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dxf2UrScript
{
    class Program
    {
        static void Main(string[] args)
        {
            Form StartForm = new StartForm();
            StartForm.ShowDialog();

/*
 *            string filePath = @"C:\Users\ilya\Desktop\ArcCircle3Lines.dxf";
            DxfReader reader = DxfReader.Create(filePath);
            if (reader != null)
            {                      
                reader.ParseFigures();
            }
            Converter.Convert(Figure.GetAllFigures(), @"C:\Users\ilya\Desktop\Draw.script");
//            Console.WriteLine(reader.Counter);
            Console.ReadLine();
*/
        }
        
    }
}
