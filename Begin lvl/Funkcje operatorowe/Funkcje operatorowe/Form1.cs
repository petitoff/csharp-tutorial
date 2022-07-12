using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funkcje_operatorowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // wczytywanie na dwa sposoby. za pomocą konstruktora oraz bez konstruktora
            // Wczytanie wartości do pierwszej liczby zespolonej
            ComplexNumber cn1 = new ComplexNumber();
            cn1.Real = Convert.ToDouble(textBox1.Text);
            cn1.Imaginary = Convert.ToDouble(textBox2.Text);

            //Wczytanie wartości do drugiej liczby zespolonej
            ComplexNumber cn2 = new ComplexNumber(Convert.ToDouble(textBox3.Text),
                Convert.ToDouble(textBox4.Text));

            // Dodawanie liczb zespolonych bez używania operatora + (dosyć niewygodne i nieintuicyjne)
            // ComplexNumber cnAdd = cn1.Add(cn2);

            // Dodanie dwóch liczb zespolonych z użyciem przeciążonego operatora +
            // i wypisanie wyniku w etykiecie "labelAdd1"
            ComplexNumber cnAdd = cn1 + cn2;
            cnAdd.Write(labelAdd1);

            // Dodanie "5" do drugiej liczby zespolonej z użyciem przeciążonego operatora +
            // i wypisanie wyniku w etykiecie "labelAdd2"
            ComplexNumber cnAdd2 = cn1 + 5;
            cnAdd2.Write(labelAdd2);

        }
    }
}
