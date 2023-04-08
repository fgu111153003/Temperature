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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Temperature
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtC_KeyUp(object sender, KeyEventArgs e)
        {
            double C;
            double output;

            if(double.TryParse(txtF.Text, out output))
            {
                C = (output - 32) * 5 / 9;
                txtC.Text = C.ToString();
            }
        }

        private void txtF_KeyUp(object sender, KeyEventArgs e)
        {
            double F;
            double output;

            if(double.TryParse(txtC.Text, out output))
            {
                F = output * (9 / 5) + 32;
                txtF.Text = F.ToString();
            }
        }

        private void txtEnter_Click(object sender, RoutedEventArgs e)
        {
            if()
        }
    }
}
