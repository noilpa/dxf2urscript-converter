using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dxf2UrScript
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string filePath = "";
            string outFilePath = "";
            try
            {
                filePath = InputFilePathText.Text;
                outFilePath = OutputFilePathText.Text;
            }
            catch (Exception) { }
            DxfReader reader = DxfReader.Create(@filePath);
            if (reader == null)
            {
                MessageLabel.Text = "Invalid path";
                return;
            }
            reader.ParseFigures();
            Converter.Convert(Figure.GetAllFigures(), outFilePath);
            MessageLabel.Text = "Convert Done";
        }

    }
}
