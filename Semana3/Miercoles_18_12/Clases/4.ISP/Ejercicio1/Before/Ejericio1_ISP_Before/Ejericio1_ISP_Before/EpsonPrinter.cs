using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio1_ISP_Before
{
    internal class EpsonPrinter : IPrinterTask
    {
        public void Fax(string content)
        {
            throw new NotImplementedException("No se puede hacer un Fax desde una imprsora Epson");
        }

        public void Print(string content)
        {
            Console.WriteLine(content); 
        }

        public void Scan(string content)
        {
            Console.WriteLine(content);
        }
    }
}
