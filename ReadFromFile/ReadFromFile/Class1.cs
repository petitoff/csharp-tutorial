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
        private readonly string _filePath;

        public Class1(string filePath)
        {
            // pobieramy "drogę" do pliku z konstruktora do lokalnej zmiennej

            this._filePath = filePath;
        }

        public void ReadFromFile(ListBox listBox)
        {
            // Funkcja odpowiedzialna jest za wczytanie tekstu z pliku do listBox

            StreamReader streamReader = new StreamReader(_filePath); // tworzymy obiekt streamReader
            List<string> lineOfText = new List<string>(); // tworzymy listę lineOfText
            string line; // zmienna pomocnicza
            while ((line = streamReader.ReadLine()) != null)
            {
                // dopóki line nie jest null czyli nie jest pusty (nie trafiliśmy na koniec pliku) to kontynuuj wczytanie

                lineOfText.Add(line); // jeżeli line nie jest null to "wkładamy" dane z line do listy lineOfText
            }

            foreach (string s in lineOfText)
            {
                // po wczytaniu pliku przesyłamy wszystkie dane do listBox

                listBox.Items.Add(s);
            }
        }
    }
}
