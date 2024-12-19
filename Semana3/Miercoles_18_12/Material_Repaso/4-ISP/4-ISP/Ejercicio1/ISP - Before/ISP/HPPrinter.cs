using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class HPPrinter : IPrinterTask
    {
        public void Fax(string content)
        {
            Console.WriteLine(content);
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
