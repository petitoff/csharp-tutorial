using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteToFile
{
    internal class Class1
    {

        public void WriteToFile(ListBox listBox, TextBox textBox)
        {

            List<string> textToWrite = new List<string>();
            foreach (object listBoxItem in listBox.Items)
            {
                textToWrite.Add(listBoxItem.ToString());
            }
            File.WriteAllLines(textBox.Text, textToWrite);
        }
    }
}
