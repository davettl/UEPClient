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
            // MessageBox.Show("Current base URL is http://localhost:8080", "Base Url");
            FormSettings formSettings = new FormSettings();
            formSettings.Owner = this;
            formSettings.ShowDialog();
        }

        private void menuOpenEventClick(object sender, RoutedEventArgs e)
        {

        }
        private void menuOpenSessionClick(object sender, RoutedEventArgs e)
        {

        }
        private void menuExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void menuAboutClick(object sender, RoutedEventArgs e)
        {
            AboutUEPClient aboutWindow = new AboutUEPClient();
            aboutWindow.ShowDialog();
        }
        
    }
}
