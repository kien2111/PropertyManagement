using QuanLyPhongTro.Common;
using QuanLyPhongTro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Common
{
    public class StackLinkedList<DataType> : IStack<DataType>
    {
        private int _size;
        private IStackNode<DataType> _currentTopNode;
        public int Size
        {
            get
            {
                return _size;
            }
        }

        public StackLinkedList()
        {
            init();
        }

        public void init()
        {
            _size = 0;
            _currentTopNode = null;
        }

        public bool isEmpty()
        {
            return _size <= 0;
        }

        public DataType pop()
        {
            if (isEmpty()) return default(DataType);
            DataType temp = _currentTopNode.data;
            if (_size == 1)
            {
                
                _currentTopNode = null;
            }
            else
            {              
                IStackNode<DataType> prevTopNode = _currentTopNode.Prev;
                prevTopNode.Next = null;
                _currentTopNode = prevTopNode;
            }
            _size--;
            return temp;
        }

        public bool push(DataType data)
        {
            if (isEmpty())
            {
                _currentTopNode = new StackLinkedListNode<DataType>(data);
            }else
            {
                IStackNode<DataType> topNode = new StackLinkedListNode<DataType>(data);
                IStackNode<DataType> prevNode = _currentTopNode;
                topNode.Prev = prevNode;
                prevNode.Next = topNode;
                _currentTopNode = topNode;
            }                
            _size++;
            return true;
        }

        public bool push(IStackNode<DataType> node)
        {
            if (isEmpty())
            {
                _currentTopNode = node;
            }else
            {
                IStackNode<DataType> prevNode = _currentTopNode;
                node.Prev = prevNode;
                prevNode.Next = node;
                _currentTopNode = node;
            }
            _size++;
            return true;
        }
    }
}
