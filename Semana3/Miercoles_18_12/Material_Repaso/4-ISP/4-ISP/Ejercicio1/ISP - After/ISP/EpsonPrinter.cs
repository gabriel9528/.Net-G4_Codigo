using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //Si solo quiero una impresora que imprima, esto estaria mal ya que la interfaz me define los 3 metodos
    internal class epsonPrinter : IScan, IPrint
    {

        public void Print(string content)
        {
            throw new NotImplementedException();
        }

        public void Scan(string content)
        {
            throw new NotImplementedException();
        }
    }
}
