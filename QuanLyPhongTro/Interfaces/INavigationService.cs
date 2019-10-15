using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Interfaces
{
    interface INavigationService
    {
        void BackWard();
        void GoTo(int indexOfAvailableCollectionFrame);
        void GoTo(int indexOfAvailableCollectionFrame, Action actionBeforeGoTo);

    }
}
