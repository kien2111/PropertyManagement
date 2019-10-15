using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Attributes
{
    [AttributeUsage(AttributeTargets.Method,AllowMultiple =true,Inherited =false)]
    public class GET : Attribute
    {
        public string Url { get; set; }

        public GET()
        {

        }
    }
}
