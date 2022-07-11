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
            try
            {
                List<string> textToWrite = new List<string>();
                foreach (object listBoxItem in listBox.Items)
                {
                    textToWrite.Add(listBoxItem.ToString());
                }

                File.WriteAllLines(textBox.Text, textToWrite);

            }
            catch (System.ArgumentException e)
            {
                MessageBox.Show($"Nie podałeś ścieżki do zapisu pliku!\n\n Kod błędu: {e}");
                return;
            }

            MessageBox.Show(@"Zapis do pliku poprawny!");
            listBox.Items.Clear();
        }
    }
}
