using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyPhongTro.Commands
{
    public static class NavigationCommands
    {
        public static RoutedCommand ShowDashBoardCommand = new RoutedCommand();
        public static RoutedCommand ShowHouseCollectionCommand = new RoutedCommand();
        public static RoutedCommand GoBack = new RoutedCommand();
        public static RoutedCommand ShowHouseDetailCommand = new RoutedCommand();
    }
}
