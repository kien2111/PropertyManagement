using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Interfaces
{
    public interface IStackNode<DataType>
    {
        IStackNode<DataType> Prev { get; set; }
        IStackNode<DataType> Next { get; set; }
        DataType data { get; set; }
    }
}
