using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for HboMax.xaml
    /// </summary>
    public partial class HboMax : Window
    {
        public HboMax()
        {
            InitializeComponent();
        }
        public void RunSelenium()
        {
            IWebDriver driver = new ChromeDriver();
        }
    }
}
