using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio1_ISP_Before
{
    internal class HPPrinter : IPrint, IScan, IFax
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
