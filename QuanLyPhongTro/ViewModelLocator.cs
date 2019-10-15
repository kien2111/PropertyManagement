using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using QuanLyPhongTro.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<HouseCollectionViewModel>();
            SimpleIoc.Default.Register<HouseDetailViewModel>();
            SimpleIoc.Default.Register<DashboardViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public HouseCollectionViewModel HouseCollection { get { return ServiceLocator.Current.GetInstance<HouseCollectionViewModel>(); } }
        public DashboardViewModel Dashboard { get { return ServiceLocator.Current.GetInstance<DashboardViewModel>(); } }
        public HouseDetailViewModel HouseDetail { get { return ServiceLocator.Current.GetInstance<HouseDetailViewModel>(); } }
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
