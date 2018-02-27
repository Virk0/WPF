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

namespace WpfApp1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var answer = int.Parse(Calc1.Text) + int.Parse(Calc2.Text);
            Result.Content = answer;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var answer = int.Parse(Calc1.Text) - int.Parse(Calc2.Text);
            Result.Content = answer;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            var answer = int.Parse(Calc1.Text) * int.Parse(Calc2.Text);
            Result.Content = answer;
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            var answer = int.Parse(Calc1.Text) / int.Parse(Calc2.Text);
            Result.Content = answer;
        }
    }
}
