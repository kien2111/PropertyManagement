using GalaSoft.MvvmLight;
using QuanLyPhongTro.Commands;
using QuanLyPhongTro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.ViewModel
{
    public class HouseDetailViewModel : ViewModelBase,ICleanable
    {
        public CommandImpl<String> EditHouseCommand { get; set; }
        public HouseDetailViewModel() :base()
        {
            EditHouseCommand = new CommandImpl<string>(OnEditHouse,CanEditHouse);
        }

        private bool CanEditHouse(string arg)
        {
            throw new NotImplementedException();
        }

        private void OnEditHouse(string obj)
        {
            throw new NotImplementedException();
        }

        public void CleanUp()
        {
            EditHouseCommand = null;
        }
    }
}
