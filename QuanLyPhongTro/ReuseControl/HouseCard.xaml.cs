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
using QuanLyPhongTro.Model;
namespace QuanLyPhongTro.ReuseControl
{
    /// <summary>
    /// Interaction logic for HouseCard.xaml
    /// </summary>
    public partial class HouseCard : UserControl
    {
        public HouseCard()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty SetRoomNumber = DependencyProperty.Register("RoomNumber", typeof(string), typeof(HouseCard), new PropertyMetadata("", new PropertyChangedCallback(OnRoomNoChanged)));
        public static readonly DependencyProperty SetRoomSquare = DependencyProperty.Register("RoomSquare", typeof(double), typeof(HouseCard), new PropertyMetadata(double.NaN, new PropertyChangedCallback(OnRoomSquareChanged)));
        public static readonly DependencyProperty SetRoomStatus = DependencyProperty.Register("RoomStatus", typeof(HouseStatus), typeof(HouseCard), new PropertyMetadata(HouseStatus.SuaChua, new PropertyChangedCallback(OnRoomStatusChanged)));
        private static void OnRoomNoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HouseCard housecard = d as HouseCard;
            housecard.OnRoomNoChanged(e);
        }
        private static void OnRoomSquareChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HouseCard housecard = d as HouseCard;
            housecard.OnRoomSquareChanged(e);
        }
        private static void OnRoomStatusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HouseCard housecard = d as HouseCard;
            housecard.OnRoomStatusChanged(e);
        }

        public string RoomNumber
        {
            get { return (string)GetValue(SetRoomNumber); }
            set { SetValue(SetRoomNumber, value); }
        }

        public HouseStatus RoomStatus
        {
            get { return (HouseStatus)GetValue(SetRoomStatus); }
            set { SetValue(SetRoomStatus, value); }
        }

        public double RoomSquare
        {
            get { return (double)GetValue(SetRoomSquare); }
            set { SetValue(SetRoomSquare, value); }
        }

        private void OnRoomNoChanged(DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is House)
            {

            }
        }

        private void OnRoomSquareChanged(DependencyPropertyChangedEventArgs e)
        {

        }

        private void OnRoomStatusChanged(DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
