using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IPrintable
    {
        string FullName { get; set; }
        void PrintFullName();
       
    }
}
