using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Interfaces
{
    public interface IMyFrame
    {
        int IndexOfFrame { get; }
        Action SetUpFrame { get; }

    }
}
