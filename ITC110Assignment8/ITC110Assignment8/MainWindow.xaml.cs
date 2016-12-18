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

namespace ITC110Assignment8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            Bill b = new ITC110Assignment8.Bill();
            b.Amount = double.Parse(amount.Text);

            double tip = 0;

            if (tip_10.IsChecked == true)
            {
                b.TipPercent = .1;
            }

            else if (tip_15.IsChecked == true)
            {
                b.TipPercent = .15;
            }

            else if (tip_20.IsChecked == true)
            {
                b.TipPercent = .2;
            }
            else
            {
                b.TipPercent = double.Parse(textOther.Text)/100;               
            }


            labelResults.Content = "Your tax is " + b.Tax().ToString() + ", your tip is " + b.CalcTip().ToString() + ", and your total is " + b.CalcTotal().ToString();



        }

    }
}