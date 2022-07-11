using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funkcje_operatorowe
{
    class ComplexNumber
    {
        public double Real; //część rzeczywista
        public double Imaginary; //część urojona

        public ComplexNumber()
        {
            Real = Imaginary = 0.0;
        }

        public ComplexNumber(double Real, double Imaginary)
        {
            this.Real = Real;
            this.Imaginary = Imaginary;
        }

        public ComplexNumber Add(ComplexNumber cn)
        {
            //"Zwykła" funkcja realizująca dodanie liczby zespolonej "cn" do danej liczby zespolonej

            ComplexNumber cn3 = new ComplexNumber();
            cn3.Real = this.Real + cn.Real;
            cn3.Imaginary = this.Imaginary + cn.Imaginary;
            return cn3;
        }

        public static ComplexNumber operator +(ComplexNumber cn1, ComplexNumber cn2)
        {
            //FUNKCJA OPERATOROWA realizująca dodawanie dwóch liczb zespolonych: "cn1" i "cn2"

            ComplexNumber cn3 = new ComplexNumber();
            cn3.Real = cn1.Real + cn2.Real;
            cn3.Imaginary = cn1.Imaginary + cn2.Imaginary;
            return cn3;
        }

        public static ComplexNumber operator +(ComplexNumber cn1, int w)
        {
            //FUNKCJA OPERATOROWA realizująca dodawanie liczby zespolonej i liczby całkowitej
            //Zwiększa część rzeczywistą i część urojoną liczby zespolonej "cn1" o wartość w

            ComplexNumber cn3 = new ComplexNumber();
            cn3.Real = cn1.Real + w;
            cn3.Imaginary = cn1.Imaginary + w;
            return cn3;
        }

        public void Write(Label lab)
        {
            //Metoda wypisująca liczbę zespoloną w etykiecie

            lab.Text = this.Real + " + " + this.Imaginary + "i";
        }
    }
}
