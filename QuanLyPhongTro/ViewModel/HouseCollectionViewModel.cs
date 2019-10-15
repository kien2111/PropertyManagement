using GalaSoft.MvvmLight;
using QuanLyPhongTro.Commands;
using QuanLyPhongTro.Common;
using QuanLyPhongTro.Interfaces;
using QuanLyPhongTro.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuanLyPhongTro.ViewModel
{
    public class HouseCollectionViewModel : ViewModelBase,ICleanable
    {
        private RangeObservableCollection<House> _houseCollection;
        //public CommandImpl LoadMoreCommand { get; set; }
        public CommandImpl<String> AddHouseCommand { get; set; }

        public HouseCollectionViewModel()
        {
            _houseCollection = new RangeObservableCollection<House>() {
                new Model.House() {Name="vzxc",Width=4123,Height=412},
                new Model.House() {Name="vzxcfsadas",Width=4125,Height=412},
                new Model.House() {Name="vzxcsà",Width=412,Height=412},
                new Model.House() {Name="vzxcf",Width=412,Height=412},
                new Model.House() {Name="vzxfasc",Width=412,Height=412},
                new Model.House() {Name="vzxc",Width=412,Height=412},
            };
            //LoadMoreCommand = new CommandImpl(OnLoadMore);

        }

        public RangeObservableCollection<House> DataHouseCollection
        {
            get { return _houseCollection; }
        }

        private void OnLoadMore()
        {
            //Button 
            //_houseCollection.AddRange(collection);
        }

        public void CleanUp()
        {
            _houseCollection = null;
            AddHouseCommand = null;
        }
    }
}
