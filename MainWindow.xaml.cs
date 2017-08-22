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

namespace ComboboxBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainVM vm = new MainVM() { Name = "Vikram", CityID = 2 };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int a = 10;
        }
    }
}
