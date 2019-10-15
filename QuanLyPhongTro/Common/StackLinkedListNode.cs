using QuanLyPhongTro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Common
{
    public class StackLinkedListNode<DataType> : IStackNode<DataType>
    {
        public StackLinkedListNode(DataType outdata)
        {
            data = outdata;
        }
        public DataType data { get; set; }

        public IStackNode<DataType> Prev
        {
            get;
            set;            
        }

        public IStackNode<DataType> Next
        {
            get;
            set;            
        }
    }
}
