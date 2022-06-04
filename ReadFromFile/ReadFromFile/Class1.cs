using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFromFile
{
    internal class Class1
    {
        private string _filePath;

        public Class1(string filePath)
        {
            this._filePath = filePath;
        }

        public void ReadFromFile(ListBox listBox)
        {
            StreamReader streamReader = new StreamReader(_filePath);
            List<string> lineOfText = new List<string>();
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                lineOfText.Add(line);
            }

            foreach (string s in lineOfText)
            {
                listBox.Items.Add(s);
            }
        }
    }
}
