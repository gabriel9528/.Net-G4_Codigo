using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //Si solo quiero una impresora y scanee que imprima,
    //esto estaria mal ya que la interfaz me define los 3 metodos
    internal class epsonPrinter : IPrinterTask
    {
        public void Fax(string content)
        {
            throw new NotImplementedException();
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
