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
using QuanLyPhongTro.ReuseControl;
using QuanLyPhongTro.Common;

namespace QuanLyPhongTro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();
            //_navigationService = new NavigationServiceImpl(_mainFrame);
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void Dashboard_Click(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void HouseCollection_Click(object sender, MouseButtonEventArgs e)
        {
            
        }
        private void ListViewControl_Click(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                switch (ListControl.Items.IndexOf(item))
                {
                    case 0:
                        
                        break;
                    case 1:
                        
                        break;
                }
            }
        }
    }
}
