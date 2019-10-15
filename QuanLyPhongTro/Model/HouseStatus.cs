using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Model
{
    public enum HouseStatus
    {
        SuaChua=0x01,
        DangThue=0x02,
        ConTrong=0x04,
    }
    public static class ExtensionHouseStatus
    {
        public static String getNameStatus(this HouseStatus house)
        {
            switch (house)
            {
                case HouseStatus.SuaChua:
                    return "Đang sửa chửa";
                case HouseStatus.DangThue:
                    return "Đang thuê";
                case HouseStatus.ConTrong:
                    return "Còn trống";
                default:
                    return "Không xác định";
            }
        }
    }
}
