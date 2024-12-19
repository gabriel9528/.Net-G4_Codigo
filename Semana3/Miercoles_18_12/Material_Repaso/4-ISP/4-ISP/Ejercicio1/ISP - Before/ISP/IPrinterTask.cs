using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IPrinterTask
    {
        void Print(string content);
    
        void Scan(string content);
    
        void Fax(string content);
    }
}
