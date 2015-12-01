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

namespace UEPClient
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

        private void menuServerUrlClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Current base URL is http://localhost:8080", "Base Url");
        }

        private void menuImportClick(object sender, RoutedEventArgs e)
        {

        }
        private void menuExportClick(object sender, RoutedEventArgs e)
        {

        }
        private void menuExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
