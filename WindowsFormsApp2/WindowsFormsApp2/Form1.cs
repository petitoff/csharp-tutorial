using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int InputValidation(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd! Nieprawidłowy typ danych!");
                return 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = InputValidation(textBox1.Text);
            int pole = 6 * a * a;
            int objetosc = 6 * 6 * 6;

            label2.Text = $"Pole sześcianu wynosi {pole}cm2, a objetosc {objetosc}cm3";
        }
    }
}
