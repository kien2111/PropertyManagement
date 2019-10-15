using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyPhongTro.Model
{
    public class House : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _width = 0;
        private double _height = 0;
        private int _id=0;
        private string _name;
        private HouseStatus _status;
        public HouseStatus Status
        {
            get { return _status; }
            set
            {
                if (_status != value) { _status = value; RaisePropertyChanged("Status"); }
            }
        }
        public string Name
        {
            get { return _name; }
            set { if (_name != value) { _name = value;RaisePropertyChanged("Room Name"); } }
        }
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value != _width)
                {
                    _width = value;
                    RaisePropertyChanged("Width");
                }else
                {

                }

            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value != _height)
                {
                    _height = value;
                    RaisePropertyChanged("Height");
                }else
                {

                }
            }
        }

        public double Square
        {
            get
            {
                return _height * _width;
            }
        }

        private void RaisePropertyChanged([CallerMemberName] String propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
