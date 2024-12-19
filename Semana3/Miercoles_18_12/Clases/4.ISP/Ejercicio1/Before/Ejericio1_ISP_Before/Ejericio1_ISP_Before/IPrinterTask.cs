using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio1_ISP_Before
{
    internal interface IPrinterTask
    {
        void Print(string content);
        void Scan(string content);
        void Fax(string content);
    }
}
