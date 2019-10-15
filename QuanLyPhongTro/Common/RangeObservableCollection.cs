using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Common
{
    public class RangeObservableCollection<T> : ObservableCollection<T>
    {
        public void AddRange(ICollection<T> collection)
        {
            foreach(var item in collection)
            {
                this.Add(item);
            }
        }
    }
}
