using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Interfaces
{
    public interface IStack<DataType>
    {
        DataType pop();
        bool push(DataType data);
        bool push(IStackNode<DataType> node);        
        void init();
        bool isEmpty();
        int Size { get; }
    }
}
