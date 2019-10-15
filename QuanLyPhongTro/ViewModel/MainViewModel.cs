using System;
using GalaSoft.MvvmLight;
using QuanLyPhongTro.Interfaces;
using System.ComponentModel;
using CommonServiceLocator;
using QuanLyPhongTro.Common;
using System.Linq;
using QuanLyPhongTro.Commands;
using System.Windows.Input;

namespace QuanLyPhongTro.ViewModel
{

    public class MainViewModel : ViewModelBase,IHostNavigator
    {
        private int _activeFrameIndex;
        private INavigationService _navigatorService;
        public HouseDetailViewModel HouseDetailVM { get; } = ServiceLocator.Current.GetInstance<HouseDetailViewModel>();
        public HouseCollectionViewModel HouseCollectionVM { get; } = ServiceLocator.Current.GetInstance<HouseCollectionViewModel>();
        public DashboardViewModel DashboardVM { get; } = ServiceLocator.Current.GetInstance<DashboardViewModel>();

        public MainViewModel()
        {
            AvailableFrameCollection = new object[] { DashboardVM,HouseCollectionVM,HouseDetailVM};
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(QuanLyPhongTro.Commands.NavigationCommands.ShowDashBoardCommand, ShowHouseCollectionExecuted));
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(QuanLyPhongTro.Commands.NavigationCommands.ShowDashBoardCommand, ShowDashBoardExecuted));
            
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(QuanLyPhongTro.Commands.NavigationCommands.ShowDashBoardCommand, ShowHouseDetailExecuted));

            _navigatorService = new FrameNavigator(this,AvailableFrameCollection);
            _navigatorService.GoTo(1);
        }

        public void ShowDashBoardExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _navigatorService.GoTo(SpecifyFrameInAvailableFramesWithType<DashboardViewModel>());
        }

        public void ShowHouseCollectionExecuted(object sender,ExecutedRoutedEventArgs e)
        {
            _navigatorService.GoTo(SpecifyFrameInAvailableFramesWithType<HouseCollectionViewModel>());
        }
        
        public void ShowHouseDetailExecuted(object sender,ExecutedRoutedEventArgs e)
        {
            _navigatorService.GoTo(SpecifyFrameInAvailableFramesWithType<HouseDetailViewModel>());
        }

        public int ActiveFrameIndex
        {
            get
            {
                return _activeFrameIndex;
            }

            set
            {
                if (value < 0) return;
                _activeFrameIndex = value;
                RaisePropertyChanged("activeframeindexchange");
            }
        }

        public object[] AvailableFrameCollection
        {
            get;
        }

        private int SpecifyFrameInAvailableFramesWithType<FrameType>()
        {
            return AvailableFrameCollection.Select((o,i)=> new { o,i}).First(a=>a.o.GetType()==typeof(FrameType)).i;
        }


    }
}