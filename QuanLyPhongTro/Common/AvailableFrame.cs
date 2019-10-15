using QuanLyPhongTro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Common
{
    public class AvailableFrame : IMyFrame
    {
        public AvailableFrame(int OutIndexFrame,Action setUpFrame)
        {
            IndexOfFrame = OutIndexFrame;
            SetUpFrame = setUpFrame;
        }

        public int IndexOfFrame
        {
            get;
        }

        public Action SetUpFrame
        {
            get;
        }
    }
}
